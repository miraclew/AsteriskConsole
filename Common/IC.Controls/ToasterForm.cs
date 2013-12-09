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
using System.Timers;

namespace IC.Controls
{
    public partial class ToasterForm : Form
    {
        private bool firstTime = true;
        private bool windowOpen = false;
        System.Timers.Timer fadeInTimer;
        System.Timers.Timer fadeOutTimer;
        public ToasterForm()
        {
            InitializeComponent();
            fadeInTimer = new System.Timers.Timer(20);
            fadeInTimer.SynchronizingObject = this;
            fadeInTimer.Elapsed += new ElapsedEventHandler(fadeTimer_Elapsed);

            fadeOutTimer = new System.Timers.Timer(20);
            fadeOutTimer.SynchronizingObject = this;
            fadeOutTimer.Elapsed += new ElapsedEventHandler(fadeOutTimer_Elapsed);
        }

        void fadeOutTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.Opacity -= 0.05;
            this.Invalidate();
            if (this.Opacity <= .05)
            {
                this.Opacity = 0;

                Thread.Sleep(10);
                fadeOutTimer.Enabled = false;
                this.Hide();
            }
        }

        void fadeTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.Opacity += 0.05;
            if (this.Opacity >= .95)
            {
                this.Opacity = 1;
                Thread.Sleep(10);
                fadeInTimer.Enabled = false;
            }
        }

        private void ToasterForm_Activated(object sender, EventArgs e)
        {
            if (firstTime)
            {
                this.Hide();
                firstTime = false;
                windowOpen = false;
            }
        }

        public void Popup()
        {
            firstTime = false;
            this.TopMost = true;

            if (!windowOpen)
            {
                windowOpen = true;
                this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
                this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
                this.Opacity = 0;
                this.Show();

                //int topValue = Screen.PrimaryScreen.WorkingArea.Height - this.Height;

                fadeInTimer.Start();
            
                //while (this.Top > topValue)//
                //{
                //    Application.DoEvents();
                //    Thread.Sleep(10);
                //    this.Top -= 10;
                //}

               // this.Top = topValue;

                //for (int i = 0; i <= 100; i++)
                //{
                //    Application.DoEvents();
                //    Thread.Sleep(10);
                //    this.Opacity = i;
                //    i++;
                //}
            }
        }

        public void Popdown()
        {
            if (windowOpen)
            {
                windowOpen = false;
                firstTime = false;
                this.TopMost = false;
                //this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
                //this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;

                //int topValue = Screen.PrimaryScreen.WorkingArea.Height;
                
                fadeOutTimer.Start();
                
                //while (this.Top < topValue)
                //{
                //    Application.DoEvents();
                //    Thread.Sleep(10);
                //    this.Top += 10;
                //}

                //this.Top = topValue;

                //this.Hide();
            }
        }

        private void ToasterForm_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //this.WindowState = FormWindowState.Minimized;
            if (this.Visible)
            {
                windowOpen = true;
            }
        }
    }
}