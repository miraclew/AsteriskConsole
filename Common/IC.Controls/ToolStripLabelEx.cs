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
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace IC.Controls
{
    [System.ComponentModel.DesignerCategory("code")]
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip | ToolStripItemDesignerAvailability.StatusStrip | ToolStripItemDesignerAvailability.MenuStrip | ToolStripItemDesignerAvailability.ContextMenuStrip)]
    public class ToolStripLabelEx : ToolStripLabel
    {
        private bool antiAlias = true;
        private StringFormat stringFormat = new StringFormat();

        public ToolStripLabelEx()
        {
            ProcessTextAlignment();
        }

        public bool AntiAliasText
        {
            get
            {
                return antiAlias;
            }
            set
            {
                antiAlias = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
           using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

                if (antiAlias)
                    e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
                else
                    e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

               if(this.Image != null && (DisplayStyle == ToolStripItemDisplayStyle.ImageAndText || DisplayStyle == ToolStripItemDisplayStyle.Image))
               {
                   e.Graphics.DrawImage(this.Image, 0, (this.Height - this.Image.Height) / 2, this.Image.Width, this.Image.Height);
               }

               if(this.Image != null && DisplayStyle == ToolStripItemDisplayStyle.ImageAndText)
                   e.Graphics.DrawString(this.Text, this.Font, textBrush, new RectangleF(this.Image.Width, 0, this.Width - this.Image.Width, this.Height), stringFormat); 
               else
                   e.Graphics.DrawString(this.Text, this.Font, textBrush, new RectangleF(0, 0, this.Width, this.Height), stringFormat); 
            }
        }

        private void ProcessTextAlignment()
        {
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
        }

        public override ContentAlignment TextAlign
        {
            get
            {
                return base.TextAlign;
            }
            set
            {
                base.TextAlign = value;
                ProcessTextAlignment();
            }
        }
    }
}
