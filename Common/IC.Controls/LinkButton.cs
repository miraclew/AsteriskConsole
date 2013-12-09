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

namespace IC.Controls
{
	/// <summary>
	/// Summary description for LinkButton.
	/// </summary>
	[DefaultEvent("Click")]
	public class LinkButton : System.Windows.Forms.UserControl
	{
		private bool				underlineOnHover = false;
		private Image				grayImage;
		private Image				normalImage;
        private Image               mouseDownImage;
        private Image               hoverImage;
        private ContentAlignment    imageAlign = ContentAlignment.MiddleLeft;

		private Color				foreColor;

		private System.Windows.Forms.PictureBox pbImage;
		private SmoothLabel lblLink;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LinkButton()
		{
			this.SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);

			InitializeComponent();

            this.DoubleBuffered = true;

			this.PerformLayout();

			this.foreColor = this.foreColor;
		}

        public override Size GetPreferredSize(Size proposedSize)
        {
            Size size = lblLink.GetPreferredSize(proposedSize);

            if (normalImage != null)
            {
                size.Width += normalImage.Width;
                size.Height += normalImage.Height;
            }

            return size;
        }

        [TypeConverter(typeof(ImageConverter)), DefaultValue(typeof(Image), null), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image MouseDownImage
        {
            get
            {
                return mouseDownImage;
            }
            set
            {
                mouseDownImage = value;
            }
        }

		[TypeConverter(typeof(ImageConverter)), DefaultValue(typeof(Image), null), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public Image LinkImage
		{
			get
			{
				return normalImage;
			}
			set
			{
				normalImage = value;

				if(normalImage == null)
				{
					pbImage.Visible = false;
					grayImage.Dispose();
					grayImage = null;
				}
				else
				{
					grayImage = CreateGrayedImage(normalImage);
					pbImage.Visible = true;
					pbImage.Width = normalImage.Width;
				}

				if(this.Enabled)
					pbImage.Image = normalImage;
				else
					pbImage.Image = grayImage;
			}
		}

		private Image CreateGrayedImage(Image inputInput)
		{
			Bitmap grayBitmap = new Bitmap(inputInput);

			for(int x = 0; x < grayBitmap.Width; x++)
			{
				for(int y = 0; y < grayBitmap.Height; y++)
				{
					Color color = grayBitmap.GetPixel(x, y);

					int avgColor = (color.R + color.G + color.B) / 3;

					grayBitmap.SetPixel(x, y, Color.FromArgb((int)(color.A * 0.5), avgColor, avgColor, avgColor));
				}
			}

			return (Image)grayBitmap;
		}

		public bool AntiAliasText
		{
			get
			{
				return lblLink.AntiAliasText;
			}
			set
			{
				lblLink.AntiAliasText = value;
			}
		}

        public ContentAlignment ImageAlign
        {
            get
            {
                return imageAlign;
            }
            set
            {
                switch (value)
                {
                    case ContentAlignment.BottomCenter:
                        pbImage.Dock = DockStyle.Bottom;
                        break;
                    case ContentAlignment.TopCenter:
                        pbImage.Dock = DockStyle.Top;
                        break;
                    case ContentAlignment.BottomLeft:
                    case ContentAlignment.MiddleLeft:
                    case ContentAlignment.TopLeft:
                        pbImage.Dock = DockStyle.Left;
                        break;
                    case ContentAlignment.BottomRight:
                    case ContentAlignment.MiddleRight:
                    case ContentAlignment.TopRight:
                        pbImage.Dock = DockStyle.Right;
                        break;
                }

                imageAlign = value;
            }
        }

        public ContentAlignment TextAlign
        {
            get
            {
                return lblLink.TextAlign;
            }
            set
            {
                lblLink.TextAlign = value;
            }
        }

		[Browsable(true)] 
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)] 
		public override string Text 
		{ 
			get
			{
				return lblLink.Text;
			} 
			set
			{
				lblLink.Text = value;
			} 
		} 

		public bool UnderlineOnHover
		{
			get
			{
				return underlineOnHover;
			}
			set
			{
				underlineOnHover = value;
			}
		}

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            lblLink.Font = this.Font;
            this.Invalidate();
        }

		protected override void OnForeColorChanged(EventArgs e)
		{
			this.foreColor = this.ForeColor;

			base.OnForeColorChanged (e);

			UpdateTextColor();
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			if(!DesignMode && underlineOnHover)
			{
				Font underlineFont = new Font(this.Font, this.Font.Style | FontStyle.Underline);

				lblLink.Font = underlineFont;
			}
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			if(!DesignMode && underlineOnHover)
			{
				lblLink.Font = this.Font;
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblLink = new Controls.SmoothLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(24, 16);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Visible = false;
            this.pbImage.DoubleClick += new System.EventHandler(this.pClick);
            this.pbImage.MouseLeave += new System.EventHandler(this.pMouseLeave);
            this.pbImage.Click += new System.EventHandler(this.pClick);
            this.pbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_MouseDown);
            this.pbImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_MouseUp);
            this.pbImage.MouseEnter += new System.EventHandler(this.pMouseEnter);
            // 
            // lblLink
            // 
            this.lblLink.AntiAliasText = true;
            this.lblLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLink.Location = new System.Drawing.Point(24, 0);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(126, 16);
            this.lblLink.StringTrimming = System.Drawing.StringTrimming.EllipsisWord;
            this.lblLink.Strong = false;
            this.lblLink.TabIndex = 1;
            this.lblLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLink.DoubleClick += new System.EventHandler(this.pClick);
            this.lblLink.MouseLeave += new System.EventHandler(this.pMouseLeave);
            this.lblLink.Click += new System.EventHandler(this.pClick);
            this.lblLink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_MouseDown);
            this.lblLink.MouseEnter += new System.EventHandler(this.pMouseEnter);
            this.lblLink.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p_MouseUp);
            // 
            // LinkButton
            // 
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.pbImage);
            this.Name = "LinkButton";
            this.Size = new System.Drawing.Size(150, 16);
            this.EnabledChanged += new System.EventHandler(this.LinkButton_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void pClick(object sender, System.EventArgs e)
		{
			if(!DesignMode)
				this.OnClick(e);
		}

		private void pMouseEnter(object sender, System.EventArgs e)
		{
			if(!DesignMode)
				this.OnMouseEnter(e);
		}

		private void pMouseLeave(object sender, System.EventArgs e)
		{
			if(!DesignMode)
				this.OnMouseLeave(e);
		}

		private void UpdateTextColor()
		{
			if(this.Enabled)
			{
				lblLink.ForeColor = this.foreColor;
			}
			else
			{
				lblLink.ForeColor = SystemColors.GrayText;
			}
		}

		private void UpdateImage()
		{
			if(this.Enabled)
			{
				if(normalImage != null)
					pbImage.Image = normalImage;
			}
			else
			{
				if(grayImage != null)
					pbImage.Image = grayImage;
			}
		}

		private void LinkButton_EnabledChanged(object sender, System.EventArgs e)
		{
			UpdateImage();
			UpdateTextColor();
        }

        private void p_MouseDown(object sender, MouseEventArgs e)
        {
            if (mouseDownImage != null)
            {
                pbImage.Image = mouseDownImage;
            }
        }

        private void p_MouseUp(object sender, MouseEventArgs e)
        {
            UpdateImage();
        }
	}
}
