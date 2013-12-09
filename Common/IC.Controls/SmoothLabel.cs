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
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Data;
using System.Windows.Forms;

namespace IC.Controls
{
    /// <summary>
    /// Summary description for SmoothLabel.
    /// </summary>
    public class SmoothLabel : System.Windows.Forms.Label
    {
        private StringFormat stringFormat;
        private SolidBrush textBrush;
        private bool antiAliasText = true;
        private bool strong = false;
        private bool enableHelp = false;
        private bool drawHelpIcon = false;
        private string helpText = "";
        private string linedHelpText = "";
        private string helpTitle = "";
        private ToolTip toolTip;

        public SmoothLabel()
        {
            toolTip = new ToolTip();
            toolTip.UseAnimation = true;
            toolTip.UseFading = true;
            //toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = ToolTipIcon.Info;

            this.SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

            textBrush = new SolidBrush(this.ForeColor);
            stringFormat = new StringFormat();

            this.DoubleBuffered = true;

            stringFormat.Trimming = StringTrimming.EllipsisWord;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            textBrush.Color = this.ForeColor;
            toolTip.ForeColor = this.ForeColor;
            this.Invalidate();
        }

        [DefaultValue(StringTrimming.EllipsisWord)]
        public StringTrimming StringTrimming
        {
            get
            {
                return stringFormat.Trimming;
            }
            set
            {
                stringFormat.Trimming = value;
                this.Invalidate();
            }
        }

        [DefaultValue(false)]
        public bool EnableHelp
        {
            get
            {
                return enableHelp;
            }
            set
            {
                enableHelp = value;

                if (enableHelp)
                    this.Cursor = Cursors.Hand;
                else
                    this.Cursor = Cursors.Default;

                this.Invalidate();
            }
        }

        [DefaultValue(false)]
        public bool Strong
        {
            get
            {
                return strong;
            }
            set
            {
                strong = value;
                this.Invalidate();
            }
        }

        [DefaultValue("")]
        [Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [Localizable(true)]
        public string HelpText
        {
            get
            {
                return helpText;
            }
            set
            {
                helpText = value;

                linedHelpText = BreakTextIntoLines(value, 80);
            }
        }

        [DefaultValue("")]
        [Editor(typeof(System.ComponentModel.Design.MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [Localizable(true)]
        public string HelpTitle
        {
            get
            {
                return helpTitle;
            }
            set
            {
                helpTitle = value;
                toolTip.ToolTipTitle = value;

                /*if (value != null && value.Length > 0)
                    toolTip.ToolTipIcon = ToolTipIcon.Info;
                else
                    toolTip.ToolTipIcon = ToolTipIcon.None;*/
            }
        }

        [DefaultValue(true)]
        public bool AntiAliasText
        {
            get
            {
                return antiAliasText;
            }
            set
            {
                antiAliasText = value;
                this.Invalidate();
            }
        }

        protected override void OnTextAlignChanged(EventArgs e)
        {
            base.OnTextAlignChanged(e);

            // Align top bottom
            switch (this.TextAlign)
            {
                case ContentAlignment.BottomCenter:
                case ContentAlignment.BottomLeft:
                case ContentAlignment.BottomRight:
                    {
                        stringFormat.LineAlignment = StringAlignment.Far;
                        break;
                    }
                case ContentAlignment.TopCenter:
                case ContentAlignment.TopLeft:
                case ContentAlignment.TopRight:
                    {
                        stringFormat.LineAlignment = StringAlignment.Near;
                        break;
                    }
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.MiddleRight:
                    {
                        stringFormat.LineAlignment = StringAlignment.Center;
                        break;
                    }
            }

            // Align left to right
            switch (this.TextAlign)
            {
                case ContentAlignment.BottomLeft:
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.TopLeft:
                    {
                        stringFormat.Alignment = StringAlignment.Near;
                        break;
                    }
                case ContentAlignment.BottomRight:
                case ContentAlignment.MiddleRight:
                case ContentAlignment.TopRight:
                    {
                        stringFormat.Alignment = StringAlignment.Far;
                        break;
                    }
                case ContentAlignment.BottomCenter:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.TopCenter:
                    {
                        stringFormat.Alignment = StringAlignment.Center;
                        break;
                    }
            }

            this.Invalidate();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Invalidate();
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            Size newSize = base.GetPreferredSize(proposedSize);

            if (antiAliasText)
            {
                using (Graphics g = this.CreateGraphics())
                {
                    g.TextRenderingHint = TextRenderingHint.AntiAlias;

                    SizeF newSizeF = g.MeasureString(this.Text, this.Font);

                    newSize.Width = (int)newSizeF.Width;
                    newSize.Height = (int)newSizeF.Height;
                }

                newSize.Width += 1;
            }

            if (enableHelp)
            {
                newSize.Width += Properties.Resources.help_icon.Width;
                newSize.Height = Math.Max(Properties.Resources.help_icon.Height, newSize.Height);
            }

            return newSize;
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);

            if (enableHelp)
            {
                drawHelpIcon = true;
                this.Invalidate();
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            
            drawHelpIcon = false;

            toolTip.Hide(this);

            if (enableHelp)
                this.Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            if (enableHelp)
            {
                toolTip.Show(linedHelpText, this, 0, this.Height);
            }
        }

        private static string BreakTextIntoLines(string text, int maxLength)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            text = text.Replace("\r\n", " \r\n ");

            string[] Words = text.Split(' ');
            int currentLineLength = 0;
            string currentLine = "";

            foreach (string currentWord in Words)
            {
                //ignore html
                if (currentWord.Length > 0)
                {
                    if (currentWord == "\r\n")
                    {
                        sb.AppendFormat("{0}\r\n", currentLine.Trim());
                        currentLine = currentWord;
                        currentLineLength = currentWord.Length;

                    }
                    else if (currentLineLength + currentWord.Length + 1 < maxLength)
                    {
                        currentLine += " " + currentWord;
                        currentLineLength += (currentWord.Length + 1);
                    }
                    else
                    {
                        sb.AppendFormat("{0}\r\n", currentLine.Trim());
                        currentLine = currentWord;
                        currentLineLength = currentWord.Length;
                    }
                }

            }

            if (currentLine != "")
                sb.AppendFormat("{0}\r\n", currentLine.Trim());

            return sb.ToString().Trim();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (enableHelp && drawHelpIcon)
            {
                e.Graphics.DrawImageUnscaled(Properties.Resources.help_icon, this.Width - Properties.Resources.help_icon.Width, 0);
            }

            if (antiAliasText)
            {
                e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

                e.Graphics.DrawString(this.Text, this.Font, textBrush, new RectangleF(0, 0, this.Width, this.Height), stringFormat);

                if (strong)
                    e.Graphics.DrawString(this.Text, this.Font, textBrush, new RectangleF(0, 0, this.Width, this.Height), stringFormat);
            }
            else
                base.OnPaint(e);
        }
    }
}
