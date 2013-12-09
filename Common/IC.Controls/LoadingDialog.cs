///////////////////////////////////////////////////////////////////////////////////////////////
//
//    This File is Part of the CallButler Open Source PBX (http://www.codeplex.com/callbutler
//
//    Copyright (c) 2005-2008, Jim Heising
//    All rights reserved.
//
//    Redistribution and use in source and binary forms, with or without modification,
//    are permitted provided that the following conditions are met:
//
//    * Redistributions of source code must retain the above copyright notice,
//      this list of conditions and the following disclaimer.
//
//    * Redistributions in binary form must reproduce the above copyright notice,
//      this list of conditions and the following disclaimer in the documentation and/or
//      other materials provided with the distribution.
//
//    * Neither the name of Jim Heising nor the names of its contributors may be
//      used to endorse or promote products derived from this software without specific prior
//      written permission.
//
//    THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
//    ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
//    WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
//    IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
//    INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
//    NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
//    PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY,
//    WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
//    ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
//    POSSIBILITY OF SUCH DAMAGE.
//
///////////////////////////////////////////////////////////////////////////////////////////////



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace IC.Controls
{
    public partial class LoadingDialog : Form
    {
        private delegate void UpdateDataHandler();
        private UpdateDataHandler updateDataDelegate;

        private const int lblHeightPadding = 17;
        private const int iconPadding = 5;

        private static LoadingDialog dialog = null;
        
        private static string statusText = "";
        private static IWin32Window owner = null;
        private static int delayStartupTime = 0;
        private static Image image;
        private static bool showProgressBar;

        private static System.Threading.Thread dialogThread;
        private static System.Threading.Mutex dialogMutex = new Mutex();
        private static bool keepOpen = false;

        private static System.Threading.Timer startupTimer = new System.Threading.Timer(new TimerCallback(StartupTimerProc), null, System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);

        public LoadingDialog()
        {
            InitializeComponent();

            updateDataDelegate = new UpdateDataHandler(UpdateData);
        }

        private static void DialogThreadProc()
        {
            try
            {
                if (keepOpen)
                {
                    if (dialog == null)
                    {
                        dialogMutex.WaitOne();
                        dialog = new LoadingDialog();

                        dialog.StartPosition = FormStartPosition.CenterScreen;
                        dialog.Show();
                        dialogMutex.ReleaseMutex();
                    }

                    if (dialog != null)
                    {
                        dialog.UpdateData();

                        while (keepOpen)
                        {
                            System.Threading.Thread.Sleep(100);
                            Application.DoEvents();
                        }

                        dialogMutex.WaitOne();
                        dialog.Close();
                        dialog.Dispose();
                        dialog = null;
                        dialogMutex.ReleaseMutex();
                    }
                }
            }
            catch
            {
            }
        }

        private void UpdateData()
        {
            if (dialog != null)
            {
                dialog.lblStatus.Text = statusText;

                if (image != null)
                {
                    dialog.pbLeftIcon.Image = image;
                    dialog.pbLeftIcon.Visible = true;
                }
                else
                    dialog.pbLeftIcon.Visible = false;

                if (showProgressBar)
                {
                    dialog.animatedProgressBar.Visible = showProgressBar;
                    dialog.animatedProgressBar.Start();
                }
                else
                {
                    dialog.animatedProgressBar.Stop();
                    dialog.animatedProgressBar.Visible = showProgressBar;
                }
            }
        }

        private static void StartupTimerProc(object state)
        {
            StartThread();
        }

        public static void ShowDialog(IWin32Window owner, string statusText, Image iconImage, bool showProgressBar, int delayStartupTime)
        {
            try
            {
                dialogMutex.WaitOne();
            }
            catch
            {
            }

            LoadingDialog.owner = owner;
            LoadingDialog.statusText = statusText;
            LoadingDialog.image = iconImage;
            LoadingDialog.showProgressBar = showProgressBar;

            if (dialog != null)
            {
                IAsyncResult ar = dialog.BeginInvoke(dialog.updateDataDelegate);
            }
            else
            {
                keepOpen = true;
                startupTimer.Change(delayStartupTime, System.Threading.Timeout.Infinite);
            }

            dialogMutex.ReleaseMutex();
        }

        private static void StartThread()
        {
            dialogThread = new Thread(new ThreadStart(DialogThreadProc));
            dialogThread.IsBackground = true;
            dialogThread.Start();
        }

        public static void HideDialog()
        {
            keepOpen = false;
        }
    }
}