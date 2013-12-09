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
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;

namespace IC.Controls
{
    [Serializable]
    public enum BlurType
    {
        Both,
        HorizontalOnly,
        VerticalOnly,
    }

    [Serializable]
    public class Blur
    {
        private int _radius = 6;
        private int[] _kernel;
        private int _kernelSum;
        private int[,] _multable;
        private BlurType _blurType;

        public Blur()
        {
            PreCalculateSomeStuff();
        }

        public Blur(int radius)
        {
            _radius = radius;
            PreCalculateSomeStuff();
        }

        private void PreCalculateSomeStuff()
        {
            int sz = _radius * 2 + 1;
            _kernel = new int[sz];
            _multable = new int[sz, 256];
            for (int i = 1; i <= _radius; i++)
            {
                int szi = _radius - i;
                int szj = _radius + i;
                _kernel[szj] = _kernel[szi] = (szi + 1) * (szi + 1);
                _kernelSum += (_kernel[szj] + _kernel[szi]);
                for (int j = 0; j < 256; j++)
                {
                    _multable[szj, j] = _multable[szi, j] = _kernel[szj] * j;
                }
            }
            _kernel[_radius] = (_radius + 1) * (_radius + 1);
            _kernelSum += _kernel[_radius];
            for (int j = 0; j < 256; j++)
            {
                _multable[_radius, j] = _kernel[_radius] * j;
            }
        }

        public Image ProcessImage(Image inputImage)
        {
            Bitmap origin = new Bitmap(inputImage);
            Bitmap blurred = new Bitmap(inputImage.Width, inputImage.Height);

            using (RawBitmap src = new RawBitmap(origin))
            {
                using (RawBitmap dest = new RawBitmap(blurred))
                {
                    int pixelCount = src.Width * src.Height;
                    int[] b = new int[pixelCount];
                    int[] g = new int[pixelCount];
                    int[] r = new int[pixelCount];
                    int[] a = new int[pixelCount];

                    int[] b2 = new int[pixelCount];
                    int[] g2 = new int[pixelCount];
                    int[] r2 = new int[pixelCount];
                    int[] a2 = new int[pixelCount];

                    int offset = src.GetOffset();
                    int index = 0;

                    unsafe
                    {
                        byte* ptr = src.Begin;
                        for (int i = 0; i < src.Height; i++)
                        {
                            for (int j = 0; j < src.Width; j++)
                            {
                                b[index] = *ptr;
                                ptr++;
                                g[index] = *ptr;
                                ptr++;
                                r[index] = *ptr;
                                ptr++;
                                a[index] = *ptr;
                                ptr++;

                                ++index;
                            }
                            ptr += offset;
                        }

                        int bsum;
                        int gsum;
                        int rsum;
                        int asum;
                        int sum;
                        int read;
                        int start = 0;
                        index = 0;
                        if (_blurType != BlurType.VerticalOnly)
                        {
                            for (int i = 0; i < src.Height; i++)
                            {
                                for (int j = 0; j < src.Width; j++)
                                {
                                    bsum = gsum = rsum = asum = sum = 0;
                                    read = index - _radius;

                                    for (int z = 0; z < _kernel.Length; z++)
                                    {
                                        if (read >= start && read < start + src.Width)
                                        {
                                            bsum += _multable[z, b[read]];
                                            gsum += _multable[z, g[read]];
                                            rsum += _multable[z, r[read]];
                                            asum += _multable[z, a[read]];
                                            sum += _kernel[z];
                                        }
                                        ++read;
                                    }

                                    b2[index] = (bsum / sum);
                                    g2[index] = (gsum / sum);
                                    r2[index] = (rsum / sum);
                                    a2[index] = (asum / sum);

                                    if (_blurType == BlurType.HorizontalOnly)
                                    {
                                        byte* pcell = dest[j, i];
                                        pcell[0] = (byte)(bsum / sum);
                                        pcell[1] = (byte)(gsum / sum);
                                        pcell[2] = (byte)(rsum / sum);
                                        pcell[3] = (byte)(asum / sum);
                                    }

                                    ++index;
                                }
                                start += src.Width;
                            }
                        }
                        if (_blurType == BlurType.HorizontalOnly)
                        {
                            return blurred;
                        }

                        int tempy;
                        for (int i = 0; i < src.Height; i++)
                        {
                            int y = i - _radius;
                            start = y * src.Width;
                            for (int j = 0; j < src.Width; j++)
                            {
                                bsum = gsum = rsum = asum = sum = 0;
                                read = start + j;
                                tempy = y;
                                for (int z = 0; z < _kernel.Length; z++)
                                {
                                    if (tempy >= 0 && tempy < src.Height)
                                    {
                                        if (_blurType == BlurType.VerticalOnly)
                                        {
                                            bsum += _multable[z, b[read]];
                                            gsum += _multable[z, g[read]];
                                            rsum += _multable[z, r[read]];
                                            asum += _multable[z, a[read]];
                                        }
                                        else
                                        {
                                            bsum += _multable[z, b2[read]];
                                            gsum += _multable[z, g2[read]];
                                            rsum += _multable[z, r2[read]];
                                            asum += _multable[z, a2[read]];
                                        }
                                        sum += _kernel[z];
                                    }
                                    read += src.Width;
                                    ++tempy;
                                }

                                byte* pcell = dest[j, i];
                                pcell[0] = (byte)(bsum / sum);
                                pcell[1] = (byte)(gsum / sum);
                                pcell[2] = (byte)(rsum / sum);
                                pcell[3] = (byte)(asum / sum);
                            }
                        }
                    }
                }
            }

            return blurred;
        }

        public int Radius
        {
            get { return _radius; }
            set
            {
                if (value < 2)
                {
                    throw new InvalidOperationException("Radius must be greater then 1");
                }
                _radius = value;
                PreCalculateSomeStuff();
            }
        }

        public BlurType BlurType
        {
            get { return _blurType; }
            set
            {
                _blurType = value;
            }
        }
    }
}
