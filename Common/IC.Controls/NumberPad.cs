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
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace IC.Controls
{
    public partial class NumberPad : UserControl
    {
        public event EventHandler<NumberPadEventArgs> NumberKeyPressed;

        private int keyPadding = 0;

        public NumberPad()
        {
            InitializeComponent();

            this.KeyPadding = 3;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (NumberKeyPressed != null)
            {
                string number = ((Button)sender).Tag.ToString();

                NumberKeyPressed(this, new NumberPadEventArgs(number));
            }
        }

        private void SetControlPadding(Control control, int padding)
        {
            control.Margin = new Padding(padding);
        }

        public int KeyPadding
        {
            get
            {
                return keyPadding;
            }
            set
            {
                keyPadding = value;

                SetControlPadding(btn0, keyPadding);
                SetControlPadding(btn1, keyPadding);
                SetControlPadding(btn2, keyPadding);
                SetControlPadding(btn3, keyPadding);
                SetControlPadding(btn4, keyPadding);
                SetControlPadding(btn5, keyPadding);
                SetControlPadding(btn6, keyPadding);
                SetControlPadding(btn7, keyPadding);
                SetControlPadding(btn8, keyPadding);
                SetControlPadding(btn9, keyPadding);
                SetControlPadding(btnStar, keyPadding);
                SetControlPadding(btnPound, keyPadding);
            }
        }
    }

    public class NumberPadEventArgs : EventArgs
    {
        public string NumberKey = "";

        public NumberPadEventArgs(string numberKey)
        {
            this.NumberKey = numberKey;
        }
    }
}
