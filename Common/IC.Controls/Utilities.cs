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

namespace IC.Controls
{
    internal class ControlUtilities
    {
        public static Image CreateReflectionImage(Image image, int reflectionHeight, int alpha, int autoOffsetThreshold, out int offset)
        {
            Bitmap reflectionImage = null;
            offset = 0;

            if (image != null)
            {
                reflectionImage = new Bitmap(image.Width, Math.Min(reflectionHeight, image.Height));

                float currentAlpha = (float)alpha / 255.0f;
                float alphaStep = currentAlpha / (float)(reflectionHeight - 1);

                int rowStart = image.Height - 1;
                int rowEnd = image.Height - Math.Min(reflectionHeight, image.Height);
                int refRow = 0;

                int offsetVal = 0;
                Color offsetPixel = Color.Empty;
                bool calcOffset = true;

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

                        reflectionImage.SetPixel(column, refRow, newPixel);
                    }

                    if (calcOffset)
                        offsetVal--;

                    refRow++;
                }

                offset = offsetVal - 1;
            }

            return reflectionImage;
        }
    }
}
