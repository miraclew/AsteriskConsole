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
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IC.Controls.AppBar
{
    /// <summary>
    /// NativeMethods needed for AppBar registration and interop.
    /// </summary>
    internal class NativeMethods
    {
        /// <summary>
        /// Sizes and Moves the AppBar to a screen edge.
        /// </summary>
        internal static void DockAppBar(IntPtr hWnd, int edge, Size idealSize)
        {
            APP_BAR_DATA abd = new APP_BAR_DATA();
            abd.cbSize = Marshal.SizeOf(abd);
            abd.hWnd = hWnd;
            abd.uEdge = edge;

            Size monitorSize = Screen.FromHandle(hWnd).Bounds.Size;

            if (edge == ABE_LEFT || edge == ABE_RIGHT)
            {
                abd.rc.top = 0;
                abd.rc.bottom = monitorSize.Height;
                if (edge == ABE_LEFT)
                {
                    abd.rc.right = idealSize.Width;
                }
                else
                {
                    abd.rc.right = monitorSize.Width;
                    abd.rc.left = abd.rc.right - idealSize.Width;
                }

            }
            else
            {
                abd.rc.left = 0;
                abd.rc.right = monitorSize.Width;
                if (edge == ABE_TOP)
                {
                    abd.rc.bottom = idealSize.Height;
                }
                else
                {
                    abd.rc.bottom = monitorSize.Height;
                    abd.rc.top = abd.rc.bottom - idealSize.Height;
                }
            }

            // Query the system for an approved size and position. 
            SHAppBarMessage(ABM_QUERYPOS, ref abd);

            // Adjust the rectangle, depending on the edge to which the 
            // appbar is anchored. 
            switch (edge)
            {
                case ABE_LEFT:
                    abd.rc.right = abd.rc.left + idealSize.Width;
                    break;
                case ABE_RIGHT:
                    abd.rc.left = abd.rc.right - idealSize.Width;
                    break;
                case ABE_TOP:
                    abd.rc.bottom = abd.rc.top + idealSize.Height;
                    break;
                case ABE_BOTTOM:
                    abd.rc.top = abd.rc.bottom - idealSize.Height;
                    break;
            }

            // Pass the final bounding rectangle to the system. 
            SHAppBarMessage(ABM_SETPOS, ref abd);

            // Move and size the appbar so that it conforms to the 
            // bounding rectangle passed to the system. 
            MoveWindow(abd.hWnd, abd.rc.left, abd.rc.top, abd.rc.right - abd.rc.left, abd.rc.bottom - abd.rc.top, true);
        }

        /// <summary>
        /// Registers the AppBar and assigns the appropriate callback message value.
        /// </summary>
        internal static bool RegisterAppBar(IntPtr hWnd, int uCallbackMessage)
        {
            APP_BAR_DATA abd = new APP_BAR_DATA();
            abd.cbSize = Marshal.SizeOf(abd);
            abd.hWnd = hWnd;
            abd.uCallbackMessage = uCallbackMessage;

            int retVal = SHAppBarMessage(ABM_NEW, ref abd);
            if (retVal == 0)
            {
                //registration failed
                return false;
            }
            return true;
        }

        /// <summary>
        /// Unregisters the AppBar.
        /// </summary>
        internal static void UnregisterAppBar(IntPtr hWnd)
        {
            APP_BAR_DATA abd = new APP_BAR_DATA();
            abd.cbSize = Marshal.SizeOf(abd);
            abd.hWnd = hWnd;
            SHAppBarMessage(ABM_REMOVE, ref abd);
        }

        private const int ABM_NEW = 0x00;
        private const int ABM_REMOVE = 0x01;
        private const int ABM_QUERYPOS = 0x02;
        private const int ABM_SETPOS = 0x03;
        private const int ABM_SETAUTOHIDEBAR = 0x08;
        private const int ABM_SETSTATE = 0x0000000a;
        private const int ABE_LEFT = 0;
        private const int ABE_TOP = 1;
        private const int ABE_RIGHT = 2;
        private const int ABE_BOTTOM = 3;
        private const int ABS_AUTOHIDE = 0x01;
        private const int ABS_ALWAYSONTOP = 0x02;

        // these are put in the wparam of callback messages
        internal const int ABN_STATECHANGE = 0x00;
        internal const int ABN_POSCHANGED = 0x01;
        internal const int ABN_FULLSCREENAPP = 0x02;
        internal const int ABN_WINDOWARRANGE = 0x03; // lParam == TRUE means hide;

        [DllImport("User32.dll", ExactSpelling = true, CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern bool MoveWindow(IntPtr hWnd, int x, int y, int cx, int cy, bool repaint);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        internal static extern int RegisterWindowMessage(string msg);

        [DllImport("Shell32.dll", CharSet = CharSet.Auto)]
        private static extern int SHAppBarMessage(int dwMessage, ref APP_BAR_DATA abd);

        [StructLayout(LayoutKind.Sequential)]
        private struct APP_BAR_DATA
        {
            public int cbSize;
            public IntPtr hWnd;
            public int uCallbackMessage;
            public int uEdge;
            public RECT rc;
            public IntPtr lParam;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;

            public RECT(int left, int top, int right, int bottom)
            {
                this.left = left;
                this.top = top;
                this.right = right;
                this.bottom = bottom;
            }

            public static RECT FromXYWH(int x, int y, int width, int height)
            {
                return new RECT(x, y, x + width, y + height);
            }
        }
    }
}
