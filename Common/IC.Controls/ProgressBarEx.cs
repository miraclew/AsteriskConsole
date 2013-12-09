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
using System.Data;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace IC.Controls
{
	/// <summary>
	/// Summary description for ProgessBarEx.
	/// </summary>
	public class ProgressBarEx : System.Windows.Forms.UserControl
	{
		private int									minValue = 0;
		private int									maxValue = 100;
		private int									upperValue = 0;
		private int									lowerValue = 0;
		private Size								rectSize = new Size(0, 0);
		private Color								minColor = Color.Gold;
		private Color								maxColor = Color.Red;
		private bool								allowDraw = true;
        private bool drawBoxes = true;

		private System.ComponentModel.Container components = null;

		public ProgressBarEx()
		{
			this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);

			InitializeComponent();

            this.DoubleBuffered = true;

			CalculateRectSize();
		}

		public int MinValue
		{
			get
			{
				return minValue;
			}
			set
			{
				if(minValue > maxValue)
					throw new Exception("MinValue must be less than MaxValue");

				minValue = value;
				this.Invalidate();
			}
		}

		public int MaxValue
		{
			get
			{
				return maxValue;
			}
			set
			{
				if(minValue > maxValue)
					throw new Exception("MaxValue must be greater than MinValue");

				maxValue = value;
				this.Invalidate();
			}
		}

		public int UpperValue
		{
			get
			{
				return upperValue;
			}
			set
			{
				upperValue = value;
				this.Invalidate();
			}
		}

		public int LowerValue
		{
			get
			{
				return lowerValue;
			}
			set
			{
				lowerValue = value;
				this.Invalidate();
			}
		}

		public Color MinColor
		{
			get
			{
				return minColor;
			}
			set
			{
				minColor = value;
				this.Invalidate();
			}
		}

		public Color MaxColor
		{
			get
			{
				return maxColor;
			}
			set
			{
				maxColor = value;
				this.Invalidate();
			}
		}

        public bool DrawTicks
        {
            get
            {
                return drawBoxes;
            }
            set
            {
                drawBoxes = value;
                this.Invalidate();
            }
        }

		internal bool AllowDraw
		{
			get
			{
				return allowDraw;
			}
			set
			{
				allowDraw = value;

				if(allowDraw)
					this.Invalidate();
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			if(allowDraw)
			{
				// Draw rects
				using(Pen borderPen = new Pen(this.ForeColor, 1))
				{
					using(LinearGradientBrush gradientBrush = new LinearGradientBrush(this.ClientRectangle, minColor, maxColor, 0, false))
					{
                        int range = maxValue - minValue;
                        int lowerAdj = lowerValue - minValue;
                        int upperAdj = lowerAdj + (upperValue - lowerValue);

                        if (drawBoxes)
                        {
                            for (int x = 0; x < this.Width - rectSize.Width; x += rectSize.Width + 2)
                            {
                                
                                if (range > 0)
                                {
                                    int lowerX = (int)((float)lowerAdj / (float)range * (float)this.Width);
                                    int upperX = (int)((float)upperAdj / (float)range * (float)this.Width);

                                    // Only draw the fill if it's within our range
                                    if (upperAdj > 0 && x >= lowerX && x <= upperX - rectSize.Width)
                                        e.Graphics.FillRectangle(gradientBrush, x, 0, rectSize.Width, rectSize.Height);
                                }

                                e.Graphics.DrawRectangle(borderPen, x, 0, rectSize.Width, rectSize.Height);
                            }
                        }
                        else
                        {
                            int lowerX = (int)((float)lowerAdj / (float)range * (float)this.Width);
                            int upperX = (int)((float)upperAdj / (float)range * (float)this.Width);

                            e.Graphics.FillRectangle(gradientBrush, lowerX, 0, upperX, rectSize.Height);

                            e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
                        }
					}
				}
			}
		}

		private void CalculateRectSize()
		{
            rectSize.Height = this.Height - 1;
            rectSize.Width = rectSize.Height * 2;
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize (e);

			CalculateRectSize();
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// ProgressBarEx
			// 
			this.ForeColor = System.Drawing.Color.Gray;
			this.Name = "ProgressBarEx";
			this.Size = new System.Drawing.Size(200, 8);

		}
		#endregion
	}
}
