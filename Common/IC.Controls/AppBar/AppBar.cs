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
using System.Text;
using System.Drawing;

namespace IC.Controls.AppBar
{
    /// <summary>
    /// This enum defines the side of the screen a 
    /// registered AppBar will be docked to.
    /// </summary>
    public enum AppBarDockStyle
    {
        None,
        ScreenLeft,
        ScreenTop,
        ScreenRight,
        ScreenBottom
    }

    public class AppBar
    {
        IntPtr windowHandle;
        private int appBarCallback;
        private AppBarDockStyle appBarDock;
        private Size idealSize = new Size(100, 100);

        public AppBar(System.Windows.Forms.IWin32Window appBarWindow)
        {
            appBarCallback = NativeMethods.RegisterWindowMessage("AppBar");
            windowHandle = appBarWindow.Handle;
            appBarDock = AppBarDockStyle.None;
        }

        public bool RegisterAppBar()
        {
            return NativeMethods.RegisterAppBar(windowHandle, this.appBarCallback);
        }

        public void UnregisterAppBar()
        {
            NativeMethods.UnregisterAppBar(windowHandle);
        }

        public AppBarDockStyle AppBarDock
        {
            get
            {
                return appBarDock;
            }
            set
            {
                appBarDock = value;
                UpdateDockedAppBarPosition(appBarDock);
            }
        }

        public Size IdealSize
        {
            get
            {
                return idealSize;
            }
            set
            {
                idealSize = value;
            }
        }

        private void UpdateDockedAppBarPosition(AppBarDockStyle dockStyle)
        {
            int edge = 0;
            switch (dockStyle)
            {
                case AppBarDockStyle.None: return;
                case AppBarDockStyle.ScreenLeft: edge = 0; break;
                case AppBarDockStyle.ScreenTop: edge = 1; break;
                case AppBarDockStyle.ScreenRight: edge = 2; break;
                default: edge = 3; break;

            }

            NativeMethods.DockAppBar(windowHandle, edge, IdealSize);
        }
    }
}
