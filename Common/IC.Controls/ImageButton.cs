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
using System.Drawing.Imaging;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Design;

namespace IC.Controls
{

	/// <summary>
	/// Summary description for ImageButton.
	/// </summary>
	[DefaultEvent("Click")]
	public class ImageButton : System.Windows.Forms.PictureBox
	{
		private Image			defaultImage;
		private Image			defaultGrayImage;
		private Image			mouseDownImage;
		private Image			toggleImage;
		private Image			toggleGrayImage;
		private Image			toggleMouseDownImage;
		private Image			hoverImage;
		private bool			buttonToggled = false;
		private bool			toggleButton = false;
		private bool			mouseDown = false;
        private bool            mouseOver = false;

		private System.ComponentModel.Container components = null;

		public ImageButton()
		{
			this.SetStyle(ControlStyles.StandardDoubleClick, false);

			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

            this.DoubleBuffered = true;
		}

		private void UpdateImage()
		{
			if(this.Enabled)
			{
				if(DesignMode)
				{
					base.Image = defaultImage;
				}
				else if(toggleButton && buttonToggled)
				{
					if(mouseDown)
					{
						if(toggleMouseDownImage != null)
							base.Image = toggleMouseDownImage;
					}
                    else if (mouseOver && hoverImage != null)
                    {
                        base.Image = hoverImage;
                    }
                    else
                    {
                        if (toggleImage != null)
                            base.Image = toggleImage;
                    }
				}
				else
				{
					if(mouseDown)
					{
						if(mouseDownImage != null)
							base.Image = mouseDownImage;
					}
                    else if (mouseOver && hoverImage != null)
                    {
                        base.Image = hoverImage;
                    }
					else
					{
						if(defaultImage != null)
							base.Image = defaultImage;
					}
				}
			}
			else
			{
				if(buttonToggled)
					base.Image = toggleGrayImage;
				else
					base.Image = defaultGrayImage;
			}
		}

		[TypeConverter(typeof(ImageConverter)), DefaultValue(typeof(Image), null), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public new Image Image
		{
			get
			{
				return defaultImage;
			}
			set
			{
				defaultImage = value;
				defaultGrayImage = CreateGrayscaleImage(defaultImage);

				UpdateImage();
			}
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
		public Image ToggleImage
		{
			get
			{
				return toggleImage;
			}
			set
			{
				toggleImage = value;
				toggleGrayImage = CreateGrayscaleImage(toggleImage);
			}
		}

		[TypeConverter(typeof(ImageConverter)), DefaultValue(typeof(Image), null), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public Image ToggleMouseDownImage
		{
			get
			{
				return toggleMouseDownImage;
			}
			set
			{
				toggleMouseDownImage = value;
			}
		}

		[TypeConverter(typeof(ImageConverter)), DefaultValue(typeof(Image), null), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public Image HoverImage
		{
			get
			{
				return hoverImage;
			}
			set
			{
				hoverImage = value;
			}
		}

		protected override void OnEnabledChanged(EventArgs e)
		{
			UpdateImage();

			base.OnEnabledChanged (e);
		}

		public bool ToggleButton
		{
			get
			{
				return toggleButton;
			}
			set
			{
				toggleButton = value;

				UpdateImage();
			}
		}

		public bool ButtonToggled
		{
			get
			{
				return buttonToggled;
			}
			set
			{
				buttonToggled = value;

				UpdateImage();
			}
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);

            mouseOver = true;
            UpdateImage();
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);

            mouseOver = false;
            UpdateImage();
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				mouseDown = true;

				UpdateImage();

				if(toggleButton)
					buttonToggled = !buttonToggled;
			}

			base.OnMouseDown(e);
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			mouseDown = false;
			UpdateImage();

			base.OnMouseUp(e);
		}

		private Image CreateGrayscaleImage(Image sourceImage)
		{
			Bitmap grayBitmap = new Bitmap(sourceImage);
            int minLevel = 255;
            int maxLevel = 0;

			for(int h = 0; h < grayBitmap.Width; h++)
			{
				for(int v = 0; v < grayBitmap.Height; v++)
				{
					Color color = grayBitmap.GetPixel(h, v);
                    int colorValue = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);

                    minLevel = Math.Min(minLevel, colorValue);
                    maxLevel = Math.Max(maxLevel, colorValue);

					grayBitmap.SetPixel(h, v, Color.FromArgb(color.A, colorValue, colorValue, colorValue));
				}
			}

            for (int h = 0; h < grayBitmap.Width; h++)
            {
                for (int v = 0; v < grayBitmap.Height; v++)
                {
                    Color color = grayBitmap.GetPixel(h, v);

                    int colorValue = color.R;

                    //colorValue = 255 

                    colorValue = Math.Min(255, colorValue);

                    grayBitmap.SetPixel(h, v, Color.FromArgb(color.A, colorValue, colorValue, colorValue));
                }
            }

			return grayBitmap;
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
			components = new System.ComponentModel.Container();
		}
		#endregion
	}
}
