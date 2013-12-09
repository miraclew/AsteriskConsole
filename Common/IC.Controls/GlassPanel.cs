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
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace IC.Controls
{
    public class GlassPanel : Panel
    {
        private int cornerRadius = 10;
        private Color hilightColor;
        private Color backColor;
        private Color borderColor = Color.WhiteSmoke;
        private int borderSize = 3;
        private float hilightBrightness = 21;
        private bool pressed = false;

        private GraphicsPath borderRectPath;
        private GraphicsPath topArcPath;
        private Bitmap outputImage;
        private Bitmap bevelOverlayImage;
        private Bitmap shadowImage;
        private float bevelOverlayImageAlpha = 0.9f;
        System.Drawing.Imaging.ImageAttributes backgroundImageAttributes;
        System.Drawing.Imaging.ImageAttributes overlayImageAttributes;

        private int shadowSize = 0;
        private Color shadowColor = Color.FromArgb(255, 0, 0, 0);
        private Blur blur;

        public GlassPanel()
        {
            borderRectPath = new GraphicsPath();
            topArcPath = new GraphicsPath();
            bevelOverlayImage = Properties.Resources.bevelOverlay;
            CalculateBackColors(Color.FromArgb(125, 44, 61, 90));

            blur = new Blur();
            blur.BlurType = BlurType.Both;
        }

        [DefaultValue(0)]
        public int ShadowSize
        {
            get
            {
                return shadowSize;
            }
            set
            {
                shadowSize = value;

                if (shadowSize > 0)
                {
                    blur.Radius = shadowSize;
                }

                RecreateBorderRectPath();
                ReCreateShadowImage();
                RecreateImage();
                this.Invalidate();
            }
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

                ReCreateShadowImage();
                RecreateImage();
                this.Invalidate();
            }
        }

        [DefaultValue(10)]
        public int CornerRadius
        {
            get
            {
                return cornerRadius;
            }
            set
            {
                cornerRadius = value;
                RecreateBorderRectPath();
                RecreateImage();
                this.Invalidate();
            }
        }

        [DefaultValue(false)]
        public bool Pressed
        {
            get
            {
                return pressed;
            }
            set
            {
                pressed = value;
                RecreateImage();
                this.Invalidate();
            }
        }

        public Color ButtonBackColor
        {
            get
            {
                return backColor;
            }
            set
            {
                CalculateBackColors(value);
                RecreateImage();
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
                RecreateImage();
                this.Invalidate();
            }
        }

        [DefaultValue(3)]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                RecreateBorderRectPath();
                RecreateImage();
                this.Invalidate();
            }
        }

        private void CalculateBackColors(Color backColor)
        {
            this.backColor = backColor;
            hilightColor = Color.FromArgb(backColor.A, Math.Min(255, (int)((float)backColor.R + hilightBrightness)), Math.Min(255, (int)((float)backColor.G + hilightBrightness)), Math.Min(255, (int)((float)backColor.B + hilightBrightness)));
            //hilightColor = Color.FromArgb(backColor.A, Math.Min(255, (int)((float)backColor.R + 21)), Math.Min(255, (int)((float)backColor.G + 21)), Math.Min(255, (int)((float)backColor.B + 21)));
            backgroundImageAttributes = GetImageAlphaAttributes(backColor.A);
            //overlayImageAttributes = GetImageAlphaAttributes(1.0f * ((float)backColor.A / 255.0f) * bevelOverlayImageAlpha);
            overlayImageAttributes = GetImageAlphaAttributes(backColor.A);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            if (outputImage != null)
            {
                e.Graphics.DrawImage(outputImage, 0, 0, this.Width, this.Height);
            }
        }

        private static System.Drawing.Imaging.ImageAttributes GetImageAlphaAttributes(float alpha)
        {
            float[][] ptsArray ={ 
                                new float[] {1, 0, 0, 0, 0},
                                new float[] {0, 1, 0, 0, 0},
                                new float[] {0, 0, 1, 0, 0},
                                new float[] {0, 0, 0, alpha, 0}, 
                                new float[] {0, 0, 0, 0, 1}};

            System.Drawing.Imaging.ColorMatrix clrMatrix = new System.Drawing.Imaging.ColorMatrix(ptsArray);

            System.Drawing.Imaging.ImageAttributes imgAttrs = new System.Drawing.Imaging.ImageAttributes();

            imgAttrs.SetColorMatrix(clrMatrix, System.Drawing.Imaging.ColorMatrixFlag.Default, System.Drawing.Imaging.ColorAdjustType.Bitmap);

            return imgAttrs;
        }

        private static System.Drawing.Imaging.ImageAttributes GetImageAlphaAttributes(int alpha)
        {
            return GetImageAlphaAttributes(1.0f * ((float)alpha / 255.0f));
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);

            RecreateBorderRectPath();
            ReCreateShadowImage();
            RecreateImage();
        }

        private void ReCreateShadowImage()
        {
            if (shadowImage != null)
                shadowImage.Dispose();

            // Draw a drop shadow if one is needed
            if (shadowSize > 0 && this.Parent != null)
            {
                using (Bitmap tmpShadowImage = new Bitmap(this.Width, this.Height))
                {
                    using (Graphics sg = Graphics.FromImage(tmpShadowImage))
                    {
                        using (SolidBrush sBrush = new SolidBrush(shadowColor))
                        {
                            sg.FillPath(sBrush, borderRectPath);
                        }
                    }

                    shadowImage = (Bitmap)blur.ProcessImage(tmpShadowImage);
                }

                // Clear out the center of our shadow image
                using (Graphics g = Graphics.FromImage(shadowImage))
                {
                    g.CompositingMode = CompositingMode.SourceCopy;

                    using (SolidBrush sBrush = new SolidBrush(Color.Transparent))
                    {
                        g.FillPath(sBrush, borderRectPath);
                    }
                }
            }
        }

        private void RecreateBorderRectPath()
        {
            if (this.Parent == null || this.Width == 0 || this.Height == 0)
                return;

            borderRectPath.Reset();

            int borderOffset = (int)((float)borderSize / 2.0f) + shadowSize;

            Rectangle tl = new Rectangle(borderOffset, borderOffset, cornerRadius, cornerRadius);
            Rectangle tr = new Rectangle(this.Width - cornerRadius - borderOffset - 1, borderOffset, cornerRadius, cornerRadius);
            Rectangle bl = new Rectangle(borderOffset, this.Height - cornerRadius - borderOffset - 1, cornerRadius, cornerRadius);
            Rectangle br = new Rectangle(this.Width - cornerRadius - borderOffset - 1, this.Height - cornerRadius - borderOffset - 1, cornerRadius, cornerRadius);

            borderRectPath.AddArc(tl, 180, 90);
            borderRectPath.AddArc(tr, 270, 90);
            borderRectPath.AddArc(br, 360, 90);
            borderRectPath.AddArc(bl, 90, 90);
            borderRectPath.CloseFigure();

            Rectangle dividerArc = new Rectangle(borderOffset, (this.Height / 2) - 20, this.Width - (borderOffset * 2) - 1, 20);

            topArcPath.Reset();

            topArcPath.AddArc(tl, 180, 90);
            topArcPath.AddArc(tr, 270, 90);
            if (pressed)
            {
                topArcPath.AddArc(dividerArc, 0, -180);
            }
            else
            {
                topArcPath.AddArc(dividerArc, 360, 180);
            }
            topArcPath.CloseFigure();
        }

        private void RecreateImage()
        {
            if (this.Parent == null || this.Width == 0 || this.Height == 0)
                return;
            
            // Create our background Image
            Bitmap backgroundImage = new Bitmap(this.Width, this.Height);

            using (Graphics g = Graphics.FromImage(backgroundImage))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Draw our background
                using (SolidBrush backBrush = new SolidBrush(Color.FromArgb(255, pressed ? hilightColor : backColor)))
                {
                    g.FillPath(backBrush, borderRectPath);
                }

                // Draw our hilight
                using (SolidBrush topBrush = new SolidBrush(Color.FromArgb(255, pressed ? backColor : hilightColor)))
                {
                    g.FillPath(topBrush, topArcPath);
                }
            }

            // Create our output image
            if (outputImage != null)
                outputImage.Dispose();

            outputImage = new Bitmap(this.Width, this.Height);

            using (Graphics og = Graphics.FromImage(outputImage))
            {
                // Draw our shadow image onto our output image
                if (shadowSize > 0 && shadowImage != null)
                {
                    og.DrawImage(shadowImage, 0, 0, this.Width, this.Height);
                }

                // Draw our background onto our output image
                og.DrawImage(backgroundImage, new Rectangle(0, 0, this.Width, this.Height), 0, 0, this.Width, this.Height, GraphicsUnit.Pixel, backgroundImageAttributes);
                backgroundImage.Dispose();

                // Stretch our bevel overlay image out
                using (Bitmap tmpBevelOverlayImage = new Bitmap(this.Width, this.Height))
                {
                    using (Graphics bg = Graphics.FromImage(tmpBevelOverlayImage))
                    {
                        //bg.DrawImage(bevelOverlayImage, 0, 0, this.Width, this.Height);
                        bg.DrawImage(bevelOverlayImage, new Rectangle(0, 0, this.Width, this.Height), 0, 0, bevelOverlayImage.Width, bevelOverlayImage.Height, GraphicsUnit.Pixel, overlayImageAttributes);
                    }

                    if (pressed)
                        tmpBevelOverlayImage.RotateFlip(RotateFlipType.Rotate180FlipNone);

                    // Draw our overlay
                    using (TextureBrush tb = new TextureBrush(tmpBevelOverlayImage))
                    {
                        og.FillPath(tb, borderRectPath);
                    }
                }

                // Draw our border
                using (Pen borderPen = new Pen(borderColor, borderSize))
                {
                    og.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    borderPen.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    og.DrawPath(borderPen, borderRectPath);
                }
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            RecreateBorderRectPath();
            ReCreateShadowImage();
            RecreateImage();

            base.OnSizeChanged(e);
        }
    }
}
