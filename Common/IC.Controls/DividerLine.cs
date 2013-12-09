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

namespace IC.Controls
{
	/// <summary>
	/// Summary description for DividerLine.
	/// </summary>
	public class DividerLine : System.Windows.Forms.UserControl
	{
		private int										gradientWidth = 10;
		private bool									vertical = false;
		private	int										lineWidth = 1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DividerLine()
		{
			this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor | ControlStyles.FixedHeight, true);

			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
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

		protected override void OnPaint(PaintEventArgs e)
		{
			if(vertical)
			{
				int halfHeight = (this.Width / 2) - (lineWidth / 2);

				using(LinearGradientBrush headerGradient = new LinearGradientBrush(new Point(0, 0), new Point(0, gradientWidth), Color.FromArgb(0, this.ForeColor.R, this.ForeColor.G, this.ForeColor.B), this.ForeColor))
				{
					e.Graphics.FillRectangle(headerGradient, halfHeight, 0, lineWidth, gradientWidth);
				}

				using(LinearGradientBrush headerGradient = new LinearGradientBrush(new Point(0, this.Height - gradientWidth), new Point(0, this.Height), this.ForeColor, Color.FromArgb(0, this.ForeColor.R, this.ForeColor.G, this.ForeColor.B)))
				{
					e.Graphics.FillRectangle(headerGradient, halfHeight, this.Height - gradientWidth, lineWidth, gradientWidth);
				}

				using(SolidBrush headerBrush = new SolidBrush(this.ForeColor))
				{
					e.Graphics.FillRectangle(headerBrush, halfHeight, gradientWidth, lineWidth, this.Height - (gradientWidth * 2));
				}	
			}
			else
			{
				int halfHeight = (this.Height / 2) - (lineWidth / 2);

				using(LinearGradientBrush headerGradient = new LinearGradientBrush(new Point(0, 0), new Point(gradientWidth, 0), Color.FromArgb(0, this.ForeColor.R, this.ForeColor.G, this.ForeColor.B), this.ForeColor))
				{
					e.Graphics.FillRectangle(headerGradient, 0, halfHeight, gradientWidth, lineWidth);
				}

				using(LinearGradientBrush headerGradient = new LinearGradientBrush(new Point(this.Width - gradientWidth, 0), new Point(this.Width, 0), this.ForeColor, Color.FromArgb(0, this.ForeColor.R, this.ForeColor.G, this.ForeColor.B)))
				{
					e.Graphics.FillRectangle(headerGradient, this.Width - gradientWidth, halfHeight, gradientWidth, lineWidth);
				}

				using(SolidBrush headerBrush = new SolidBrush(this.ForeColor))
				{
					e.Graphics.FillRectangle(headerBrush, gradientWidth, halfHeight, this.Width - (gradientWidth * 2), lineWidth);
				}
			}
		}

		public bool Vertical
		{
			get
			{
				return vertical;
			}
			set
			{
				vertical = value;
				this.Invalidate();
			}
		}

		public int LineWidth
		{
			get
			{
				return lineWidth;
			}
			set
			{
				lineWidth = value;
				this.Invalidate();
			}
		}

		public int GradientWidth
		{
			get
			{
				return gradientWidth;
			}
			set
			{
				gradientWidth = value;
				this.Invalidate();
			}
		}


		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// DividerLine
			// 
			this.Name = "DividerLine";
			this.Size = new System.Drawing.Size(280, 1);

		}
		#endregion
	}
}
