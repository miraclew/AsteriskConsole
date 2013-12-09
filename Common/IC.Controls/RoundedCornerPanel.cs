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
using System.Data;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace IC.Controls
{
	/// <summary>
	/// Summary description for RoundedCornerPanel.
	/// </summary>
	/// 
	[Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
	public class RoundedCornerPanel : System.Windows.Forms.ScrollableControl
	{
		private int					cornerRadius = 10;
		private SolidBrush			backBrush;
		private Color				panelColor = Color.White;
		private Pen					borderPen;
		private	GraphicsPath		path;
        private bool displayShadow = false;
        private bool fadeShadow = true;
        private int shadowOffset = 5;
        private Color shadowColor = Color.Gray;

		private System.ComponentModel.Container components = null;

		public RoundedCornerPanel()
		{
			this.SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
           
			InitializeComponent();

            this.DoubleBuffered = true;

			backBrush = new SolidBrush(panelColor);
			borderPen = new Pen(this.ForeColor, 1.0f);
			path = new GraphicsPath();
			CreateGraphicsPath();
		}

		private void CreateGraphicsPath()
		{
			int cornerDiameter = cornerRadius * 2;

			path.Reset();

			int halfBorderWidth = (int)(borderPen.Width / 2);

            if (displayShadow)
            {
                path.AddArc(halfBorderWidth, halfBorderWidth, cornerDiameter, cornerDiameter, 180, 90);
                path.AddArc(this.Width - cornerDiameter - halfBorderWidth - shadowOffset - 1, halfBorderWidth, cornerDiameter, cornerDiameter, 270, 90);
                path.AddArc(this.Width - cornerDiameter - halfBorderWidth - shadowOffset - 1, this.Height - cornerDiameter - halfBorderWidth - shadowOffset - 1, cornerDiameter, cornerDiameter, 0, 90);
                path.AddArc(halfBorderWidth, this.Height - cornerDiameter - halfBorderWidth - shadowOffset - 1, cornerDiameter, cornerDiameter, 90, 90);
            }
            else
            {
                path.AddArc(halfBorderWidth, halfBorderWidth, cornerDiameter, cornerDiameter, 180, 90);
                path.AddArc(this.Width - cornerDiameter - halfBorderWidth - 1, halfBorderWidth, cornerDiameter, cornerDiameter, 270, 90);
                path.AddArc(this.Width - cornerDiameter - halfBorderWidth - 1, this.Height - cornerDiameter - halfBorderWidth - 1, cornerDiameter, cornerDiameter, 0, 90);
                path.AddArc(halfBorderWidth, this.Height - cornerDiameter - halfBorderWidth - 1, cornerDiameter, cornerDiameter, 90, 90);
            }

			path.CloseFigure();
		}

		/*private void Redraw()
		{
			this.Draw(null);
		}*/

		protected override void OnForeColorChanged(EventArgs e)
		{
			borderPen.Color = this.ForeColor;
			this.Invalidate();

			base.OnForeColorChanged(e);
		}

		public float BorderSize
		{
			get
			{
				return borderPen.Width;
			}
			set
			{
				borderPen.Width = value;
				CreateGraphicsPath();
				this.Invalidate();
			}
		}

		protected override void OnBackColorChanged(EventArgs e)
		{
			base.OnBackColorChanged (e);
			this.Invalidate();
		}

        public Color ShadowColor
        {
            get
            {
                return shadowColor;
            }
            set
            {
                shadowColor = value;
                this.Invalidate();
            }
        }

        /*public bool FadeShadow
        {
            get
            {
                return fadeShadow;
            }
            set
            {
                fadeShadow = value;
                this.Invalidate();
            }
        }*/

        public bool DisplayShadow
        {
            get
            {
                return displayShadow;
            }
            set
            {
                this.displayShadow = value;
                CreateGraphicsPath();
                this.Invalidate();
            }
        }

        public int ShadowOffset
        {
            get
            {
                return shadowOffset;
            }
            set
            {
                shadowOffset = value;
                CreateGraphicsPath();
                this.Invalidate();
            }
        }

		public Color PanelColor
		{
			get
			{
				return panelColor;
			}
			set
			{
				panelColor = value;
				backBrush.Color = value;
				this.Invalidate();
			}
		}

		public int CornerRadius
		{
			get
			{
				return cornerRadius;
			}
			set
			{
				cornerRadius = value;
				CreateGraphicsPath();
				this.Invalidate();
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//e.Graphics.Clear(this.BackColor);

			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw the shadow
            if (displayShadow)
            {
                using (SolidBrush shadowBrush = new SolidBrush(shadowColor))
                {
                    /*if (fadeShadow)
                    {
                        for (int index = shadowOffset; index >= 0; index--)
                        {
                            
                        }
                    }
                    else
                    {*/
                        e.Graphics.TranslateTransform(shadowOffset, shadowOffset);
                        e.Graphics.FillPath(shadowBrush, path);
                        e.Graphics.ResetTransform();
                    //}
                }
            }

			e.Graphics.FillPath(backBrush, path);
			e.Graphics.DrawPath(borderPen, path);
		}

		/*protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			base.OnPaintBackground (pevent);
		}*/



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
			// RoundedCornerPanel
			// 
			this.Name = "RoundedCornerPanel";
			this.Size = new System.Drawing.Size(144, 88);
			this.Resize += new System.EventHandler(this.RoundedCornerPanel_Resize);

		}
		#endregion

		private void RoundedCornerPanel_Resize(object sender, System.EventArgs e)
		{
			CreateGraphicsPath();
			this.Invalidate();
		}
	}
}
