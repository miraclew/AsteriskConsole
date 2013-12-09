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
	/// Summary description for GradientPanel.
	/// </summary>
	public class GradientPanel : System.Windows.Forms.Panel
	{
		private float							gradientAngle = 0.0f;
        private float borderWidth = 1.0f;
        private bool drawBorder = false;
        private Color borderColor = Color.Black;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GradientPanel()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

            this.DoubleBuffered = true;
		}

		public float GradientAngle
		{
			get
			{
				return gradientAngle;
			}
			set
			{
				gradientAngle = value;

				this.Invalidate(false);
			}
		}

        public bool DrawBorder
        {
            get
            {
                return drawBorder;
            }
            set
            {
                drawBorder = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public float BorderWidth
        {
            get
            {
                return borderWidth;
            }
            set
            {
                borderWidth = value;
                this.Invalidate();
            }
        }

		//protected override void OnBackColorChanged(EventArgs e)
		//{
		//	base.OnBackColorChanged (e);
		//}


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
            if (this.ClientRectangle.Width > 0 && this.ClientRectangle.Height > 0)
            {
                using (LinearGradientBrush gradientBrush = new LinearGradientBrush(this.ClientRectangle, this.BackColor, this.ForeColor, gradientAngle))
                {
                    e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
                }

                if (drawBorder)
                {
                    using (Pen borderPen = new Pen(borderColor, borderWidth))
                    {
                        int halfBorderWidth = (int)(borderPen.Width / 2);

                        e.Graphics.DrawRectangle(borderPen, halfBorderWidth, halfBorderWidth, this.Width - halfBorderWidth - 1, this.Height - halfBorderWidth - 1);
                    }
                }
            }
			//base.OnPaint (e);
		}

		protected override void OnResize(EventArgs e)
		{
			this.Invalidate();
			base.OnResize (e);
		}



		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// GradientPanel
			// 
			this.Name = "GradientPanel";
			this.Size = new System.Drawing.Size(256, 48);

		}
		#endregion
	}
}
