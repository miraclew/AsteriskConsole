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
    public partial class TrackBarEx : UserControl
    {
        public event EventHandler ValueChanged;
        public event EventHandler Scrolling;

        private Orientation orientation = Orientation.Horizontal;
        private int value = 0;
        private int maxValue = 100;
        private int minValue = 0;
        private bool moving = false;
        private Point mouseDownPos = new Point();
        private int trackerStartPos = 0;

        public TrackBarEx()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
        }

        public Orientation Orientation
        {
            get
            {
                return orientation;
            }
            set
            {
                orientation = value;

                int oldWidth = this.Width;
                int oldHeight = this.Height;

                if (orientation == Orientation.Horizontal)
                {
                    if (this.Height > this.Width)
                    {
                        this.Height = oldWidth;
                        this.Width = oldHeight;
                    }
                }
                else
                {
                    if (this.Height < this.Width)
                    {
                        this.Height = oldWidth;
                        this.Width = oldHeight;
                    }
                }
            }
        }

        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                if (value > maxValue || value < minValue)
                    throw new ArgumentOutOfRangeException("Value");

                this.value = value;
                UpdateTracker();

                if (ValueChanged != null)
                    ValueChanged(this, EventArgs.Empty);
            }
        }

        public int MinValue
        {
            get
            {
                return minValue;
            }
            set
            {
                if (minValue >= maxValue)
                    throw new ArgumentOutOfRangeException("MinValue", "Must be less than MaxValue");

                minValue = value;

                if (this.Value < minValue)
                    this.Value = minValue;
            }
        }

        public int MaxValue
        {
            get
            {
                return maxValue;
            }
            set
            {
                if (minValue >= maxValue)
                    throw new ArgumentOutOfRangeException("MaxValue", "Must be greater than MinValue");

                maxValue = value;

                if (this.Value > maxValue)
                    this.Value = maxValue;
            }
        }

        public Cursor TrackerCursor
        {
            get
            {
                return pbTracker.Cursor;
            }
            set
            {
                pbTracker.Cursor = value;
            }
        }

        public Image TrackerImage
        {
            get
            {
                return pbTracker.Image;
            }
            set
            {
                pbTracker.Image = value;
                UpdateTracker();
            }
        }

        private void TrackBarEx_Resize(object sender, EventArgs e)
        {
            UpdateTracker();
        }

        private void UpdateTracker()
        {
            int valueRange = this.MaxValue - this.MinValue;
            float valuePercentage = (float)(this.Value - this.MinValue) / (float)valueRange;

            if (orientation == Orientation.Horizontal)
            {
                pbTracker.Top = (this.Height - pbTracker.Height) / 2;
                pbTracker.Left = (int)((float)(this.Width - pbTracker.Width) * valuePercentage);
            }
            else
            {
                pbTracker.Left = (this.Width - pbTracker.Width) / 2;
                pbTracker.Top = this.Height - pbTracker.Height - (int)((float)(this.Height - pbTracker.Height) * valuePercentage);
            }

            this.Invalidate();
        }

        private void UpdateValue()
        {
            int valueRange = this.MaxValue - this.MinValue;

            if (orientation == Orientation.Horizontal)
            {
                this.value = (int)((float)pbTracker.Left / (float)(this.Width - pbTracker.Width) * (float)valueRange) + this.MinValue;
            }
            else
            {
                this.value = this.maxValue - ((int)((float)pbTracker.Top / (float)(this.Height - pbTracker.Height) * (float)valueRange) + this.MinValue);
            }

            if (ValueChanged != null)
                ValueChanged(this, EventArgs.Empty);
        }

        private void pbTracker_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            mouseDownPos = Cursor.Position;

            if (orientation == Orientation.Horizontal)
                trackerStartPos = pbTracker.Left;
            else
                trackerStartPos = pbTracker.Top;
        }

        private void pbTracker_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }

        private void pbTracker_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                if (orientation == Orientation.Horizontal)
                {
                    int trackerPos = Cursor.Position.X - mouseDownPos.X + trackerStartPos;

                    if (trackerPos >= 0 && trackerPos <= this.Width - pbTracker.Width)
                        pbTracker.Left = trackerPos;
                    else if (trackerPos < 0)
                        pbTracker.Left = 0;
                    else
                        pbTracker.Left = this.Width - pbTracker.Width;
                }
                else
                {
                    int trackerPos = Cursor.Position.Y - mouseDownPos.Y + trackerStartPos;

                    if (trackerPos >= 0 && trackerPos <= this.Height - pbTracker.Height)
                        pbTracker.Top = trackerPos;
                    else if (trackerPos < 0)
                        pbTracker.Top = 0;
                    else
                        pbTracker.Top = this.Height - pbTracker.Height;
                }

                UpdateValue();

                if (Scrolling != null)
                    Scrolling(this, EventArgs.Empty);
            }
        }

        private void TrackBarEx_MouseClick(object sender, MouseEventArgs e)
        {
            if (orientation == Orientation.Horizontal)
            {
                int trackerPos = e.X - pbTracker.Width / 2;

                if (trackerPos >= 0 && trackerPos <= this.Width - pbTracker.Width)
                    pbTracker.Left = trackerPos;
                else if (trackerPos < 0)
                    pbTracker.Left = 0;
                else
                    pbTracker.Left = this.Width - pbTracker.Width;
            }
            else
            {
                int trackerPos = e.Y - pbTracker.Height / 2;

                if (trackerPos >= 0 && trackerPos <= this.Height - pbTracker.Height)
                    pbTracker.Top = trackerPos;
                else if (trackerPos < 0)
                    pbTracker.Top = 0;
                else
                    pbTracker.Top = this.Height - pbTracker.Height;
            }

            UpdateValue();

            if (Scrolling != null)
                Scrolling(this, EventArgs.Empty);
        }
    }
}
