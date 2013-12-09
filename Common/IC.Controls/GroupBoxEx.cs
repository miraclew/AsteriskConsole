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
using System.Drawing.Text;

namespace IC.Controls
{
	/// <summary>
	/// Summary description for GroupBoxEx.
	/// </summary>
	[Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
	public class GroupBoxEx : System.Windows.Forms.ScrollableControl
	{
		private const int				headerMargin = 5;

		private	GraphicsPath			headerPath = new GraphicsPath();
		private	Color					headerColor = Color.Gray;
		private int						cornerRadius = 10;
		private bool					dividerAbove = true;
		private bool					antiAliasText = true;
		private bool					drawLeftDivider = true;

		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GroupBoxEx()
		{
			//this.SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);

			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

            this.DoubleBuffered = true;
			// TODO: Add any initialization after the InitializeComponent call
			//CreateGraphicsPath();
		}

		/*private void CreateGraphicsPath()
		{
			int cornerDiameter = cornerRadius * 2;

			headerPath.Reset();

			int headerHeight = (int)this.CreateGraphics().MeasureString("Ij", this.Font).Height + (headerMargin * 2);

			if(dividerAbove)
			{
				headerPath.AddLine(0, headerHeight, 0, cornerRadius);
				headerPath.AddArc(0, 0, cornerDiameter, cornerDiameter, 180, 90);
				headerPath.AddLine(cornerRadius, 0, this.Width, 0);
			}
			else
			{

			}
		}*/

		private void Draw(Graphics g)
		{
			int headerHeight = (int)g.MeasureString("Ij", this.Font).Height + (headerMargin * 2);
			LinearGradientBrush horizHeaderGradient = new LinearGradientBrush(new Point(cornerRadius - 1, 0), new Point(this.Width, 0), headerColor, Color.FromArgb(0, headerColor.R, headerColor.G, headerColor.B));
			LinearGradientBrush vertHeaderGradient;
			Pen headerPen = new Pen(headerColor);
			
			// Draw header
			if(dividerAbove)
			{
				vertHeaderGradient = new LinearGradientBrush(new Point(0, cornerRadius), new Point(0, headerHeight), headerColor, Color.FromArgb(0, headerColor.R, headerColor.G, headerColor.B));

				if(drawLeftDivider)
				{
					g.FillRectangle(horizHeaderGradient, cornerRadius, 0, this.Width - cornerRadius, 1);
					g.FillRectangle(vertHeaderGradient, 0, cornerRadius, 1, headerHeight - cornerRadius);
				
					g.SmoothingMode = SmoothingMode.AntiAlias;
					g.DrawArc(headerPen, 0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
				}
				else
				{
					g.FillRectangle(horizHeaderGradient, cornerRadius - 1, 0, this.Width - cornerRadius, 1);
					
					horizHeaderGradient = new LinearGradientBrush(new Point(0, 0), new Point(cornerRadius, 0), Color.FromArgb(0, headerColor.R, headerColor.G, headerColor.B), headerColor);

					g.FillRectangle(horizHeaderGradient, 0, 0, cornerRadius, 1);
				}
			}
			else
			{
				vertHeaderGradient = new LinearGradientBrush(new Point(0, 0), new Point(0, headerHeight - cornerRadius + 1), Color.FromArgb(0, headerColor.R, headerColor.G, headerColor.B), headerColor);

				if(drawLeftDivider)
				{
					g.FillRectangle(horizHeaderGradient, cornerRadius, headerHeight, this.Width - cornerRadius, 1);
					g.FillRectangle(vertHeaderGradient, 0, 0,  1, headerHeight - cornerRadius + 1);
				
					g.SmoothingMode = SmoothingMode.AntiAlias;
					g.DrawArc(headerPen, 0, headerHeight - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
				}
				else
				{
					g.FillRectangle(horizHeaderGradient, cornerRadius - 1, headerHeight, this.Width - cornerRadius, 1);
					
					horizHeaderGradient = new LinearGradientBrush(new Point(0, 0), new Point(cornerRadius, 0), Color.FromArgb(0, headerColor.R, headerColor.G, headerColor.B), headerColor);

					g.FillRectangle(horizHeaderGradient, 0, headerHeight, cornerRadius, 1);
				}
			}

			// Draw Text
            if (antiAliasText)
            {
                g.TextRenderingHint = TextRenderingHint.AntiAlias;

                using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
                {
                    g.DrawString(this.Text, this.Font, textBrush, headerMargin, headerMargin);
                }
                
            }
            else
            {
                g.TextRenderingHint = TextRenderingHint.SystemDefault;

                TextRenderer.DrawText(g, this.Text, this.Font, new Point(headerMargin, headerMargin), this.ForeColor);
            }
			
			horizHeaderGradient.Dispose();
			vertHeaderGradient.Dispose();
		}

		public bool DividerAbove
		{
			get
			{
				return dividerAbove;
			}
			set
			{
				dividerAbove = value;
				this.Invalidate();
			}
		}

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

		public bool DrawLeftDivider
		{
			get
			{
				return drawLeftDivider;
			}
			set
			{
				drawLeftDivider = value;
				this.Invalidate();
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Draw(e.Graphics);
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.Invalidate();
		}

		[Browsable(true)] 
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)] 
		public override string Text 
		{ 
			get
			{
				return base.Text;
			} 
			set
			{
				base.Text = value;
				this.Invalidate();
			} 
		}

		public Color HeaderColor
		{
			get
			{
				return headerColor;
			}
			set
			{
				headerColor = value;
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
				this.Invalidate();
			}
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
			// GroupBoxEx
			// 
			this.Name = "GroupBoxEx";
			this.Size = new System.Drawing.Size(304, 192);

		}
		#endregion
	}
}
