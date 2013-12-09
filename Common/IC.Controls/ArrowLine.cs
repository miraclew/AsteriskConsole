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
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace IC.Controls
{
    public enum LineOrientation
    {
        Horizontal,
        Vertical
    }

    public partial class ArrowLine : Control
    {
        private LineOrientation lineOrientation = LineOrientation.Horizontal;
        private float lineWidth = 1.0f;
        private bool arrowAtStart = false;
        private bool arrowAtEnd = true;
        private float arrowLength = 5.0f;
        private float arrowWidth = 5.0f;
        private GraphicsPath arrowPath = new GraphicsPath();

        public ArrowLine()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);

            InitializeComponent();
            this.DoubleBuffered = true;
            UpdateArrowPath();
        }

        public void UpdateArrowPath()
        {
            arrowPath = new GraphicsPath();

            float arrowVert = lineWidth * arrowWidth / 2.0f;
            float arrowHoriz = lineWidth * arrowLength;

            arrowPath.AddLine(0, 0, -arrowHoriz, -arrowVert); 
            arrowPath.AddLine(-arrowHoriz, arrowVert, 0, 0);     
              
        }

        public float ArrowLengthPercentage
        {
            get
            {
                return arrowLength;
            }
            set
            {
                arrowLength = value;
                UpdateArrowPath();
                this.Invalidate();
            }
        }

        public float ArrowWidthPercentage
        {
            get
            {
                return arrowWidth;
            }
            set
            {
                arrowWidth = value;
                UpdateArrowPath();
                this.Invalidate();
            }
        }

        public bool ArrowAtStart
        {
            get
            {
                return arrowAtStart;
            }
            set
            {
                arrowAtStart = value;
                this.Invalidate();
            }
        }

        public bool ArrowAtEnd
        {
            get
            {
                return arrowAtEnd;
            }
            set
            {
                arrowAtEnd = value;
                this.Invalidate();
            }
        }

        public float LineWidth
        {
            get
            {
                return lineWidth;
            }
            set
            {
                lineWidth = value;
                UpdateArrowPath();
                this.Invalidate();
            }
        }

        public LineOrientation LineOrientation
        {
            get
            {
                return lineOrientation;
            }
            set
            {
                lineOrientation = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (lineWidth > 0)
            {
                pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                float arwLength = lineWidth * arrowLength;

                //pe.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);

                // Draw Line
                using (Pen linePen = new Pen(this.ForeColor, lineWidth))
                {
                    Point startPoint = new Point();
                    Point endPoint = new Point();

                    if (lineOrientation == LineOrientation.Horizontal)
                    {
                        startPoint.X = 0;
                        startPoint.Y = this.Height / 2;

                        endPoint.X = this.Width;
                        endPoint.Y = this.Height / 2;

                        if (arrowAtStart)
                            startPoint.X += (int)arwLength;

                        if (arrowAtEnd)
                            endPoint.X -= (int)arwLength;
                    }
                    else
                    {
                        startPoint.X = this.Width / 2;
                        startPoint.Y = 0;

                        endPoint.X = this.Width / 2;
                        endPoint.Y = this.Height;

                        if (arrowAtStart)
                            startPoint.Y += (int)arwLength;

                        if (arrowAtEnd)
                            endPoint.Y -= (int)arwLength;
                    }

                    pe.Graphics.DrawLine(linePen, startPoint, endPoint);

                    using (SolidBrush arrowBrush = new SolidBrush(this.ForeColor))
                    {
                        if (arrowAtEnd)
                        {
                            if (lineOrientation == LineOrientation.Horizontal)
                            {
                                pe.Graphics.TranslateTransform(this.Width - 1, this.Height / 2);
                            }
                            else
                            {
                                pe.Graphics.TranslateTransform(this.Width / 2, this.Height - 1);
                                pe.Graphics.RotateTransform(90.0f);
                            }

                            pe.Graphics.FillPath(arrowBrush, arrowPath);
                        }

                        pe.Graphics.ResetTransform();

                        if (arrowAtStart)
                        {
                            if (lineOrientation == LineOrientation.Horizontal)
                            {
                                pe.Graphics.TranslateTransform(0, this.Height / 2);
                                pe.Graphics.RotateTransform(180.0f);
                            }
                            else
                            {
                                pe.Graphics.TranslateTransform(this.Width / 2, 0);
                                pe.Graphics.RotateTransform(-90.0f);
                            }

                            pe.Graphics.FillPath(arrowBrush, arrowPath);
                        }
                    }
                }
            }
            else
                base.OnPaint(pe);
        } 
    }
}
