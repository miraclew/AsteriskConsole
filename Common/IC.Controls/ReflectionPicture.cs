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
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace IC.Controls
{
    public partial class ReflectionPicture : UserControl
    {
        private Image image;
        private Image reflectionImage;
        private int reflectionHeight = 20;
        private bool autoOffset = false;
        private int autoOffsetThreshold = 50;
        private int alpha = 100;
        private int offset = 0;

        public ReflectionPicture()
        {
            InitializeComponent();
        }

        [Category("Appearance")]
        [TypeConverter(typeof(ImageConverter)), DefaultValue(typeof(Image), null), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Localizable(true)]
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                CreateReflectionImage();
                ProcessAutoSize();
                this.Refresh();
            }
        }

        [Category("Reflection")]
        [DefaultValue(0), Localizable(true)]
        public int Offset
        {
            get
            {
                return offset;
            }
            set
            {
                if (!autoOffset)
                {
                    offset = value;
                    ProcessAutoSize();
                    this.Refresh();
                }
            }
        }

        [Category("Reflection")]
        [DefaultValue(100)]
        public int Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                alpha = Math.Max(Math.Min(value, 255), 0);

                CreateReflectionImage();
                ProcessAutoSize();
                this.Refresh();
            }
        }

        [Category("Reflection")]
        [DefaultValue(50)]
        public int AutoOffsetThreshold
        {
            get
            {
                return autoOffsetThreshold;
            }
            set
            {
                autoOffsetThreshold = value;
                CreateReflectionImage();
                ProcessAutoSize();
                this.Refresh();
            }
        }

        [Category("Reflection")]
        [DefaultValue(false)]
        public bool AutoOffset
        {
            get
            {
                return autoOffset;
            }
            set
            {
                autoOffset = value;
                CreateReflectionImage();
                ProcessAutoSize();
                this.Refresh();
            }
        }

        [Category("Reflection")]
        [DefaultValue(20), Localizable(true)]
        public int ReflectionHeight
        {
            get
            {
                return reflectionHeight;
            }
            set
            {
                reflectionHeight = value;
                CreateReflectionImage();
                ProcessAutoSize();
                this.Refresh();
            }
        }

        protected override void OnAutoSizeChanged(EventArgs e)
        {
            ProcessAutoSize();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            ProcessAutoSize();
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            if (image != null)
                return new Size(image.Width, image.Height + Math.Min(reflectionHeight, image.Height) + offset);
            else
                return new Size(50, 50);
        }

        private void ProcessAutoSize()
        {
            if(this.AutoSize)
                this.Size = GetPreferredSize(Size.Empty);
        }

        private void CreateReflectionImage()
        {
            int offsetVal = 0;

            reflectionImage = ControlUtilities.CreateReflectionImage(image, reflectionHeight, alpha, autoOffsetThreshold, out offsetVal);

            if (autoOffset)
                offset = offsetVal;
            /*if (image != null)
            {
                if (reflectionImage != null)
                    reflectionImage.Dispose();

                Bitmap bmp = new Bitmap(image.Width, Math.Min(reflectionHeight, image.Height));
                //Graphics g = Graphics.FromImage(bmp);

                float currentAlpha = (float)alpha / 255.0f;
                float alphaStep = currentAlpha / (float)(reflectionHeight - 1);

                int rowStart = image.Height - 1;
                int rowEnd = image.Height - Math.Min(reflectionHeight, image.Height);
                int refRow = 0;


                int offsetVal = 0;
                Color offsetPixel = Color.Empty;
                bool calcOffset = autoOffset;

                for (int row = rowStart; row > rowEnd; row--)
                {
                    currentAlpha -= alphaStep;

                    for (int column = 0; column < image.Width; column++)
                    {
                        // Get our current pixel
                        Color imagePixel = ((Bitmap)image).GetPixel(column, row);

                        if (calcOffset)
                        {
                            if (offsetPixel != Color.Empty && imagePixel != offsetPixel && imagePixel.A > autoOffsetThreshold)
                                calcOffset = false;
                            else
                                offsetPixel = imagePixel;
                        }

                        // Recolor our pixel with the right alpha
                        Color newPixel = Color.FromArgb((int)(imagePixel.A * currentAlpha), imagePixel.R, imagePixel.G, imagePixel.B);

                        bmp.SetPixel(column, refRow, newPixel);
                    }

                    if(calcOffset)
                        offsetVal--;
                    
                    refRow++;
                }

                if (autoOffset)
                    offset = offsetVal - 1;

                reflectionImage = bmp;
            }*/
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (image != null)
            {
                int mainImageY = (this.Height - (image.Height + reflectionImage.Height + offset)) / 2;

                // Draw the reflection image
                e.Graphics.DrawImage(reflectionImage, (this.Width - image.Width) / 2, mainImageY + image.Height + offset, reflectionImage.Width, reflectionImage.Height);

                // Draw the main image
                e.Graphics.DrawImage(image, (this.Width - image.Width) / 2, mainImageY, image.Width, image.Height);
            }
        }
    }
}
