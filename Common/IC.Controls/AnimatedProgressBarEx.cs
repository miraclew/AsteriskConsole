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
	/// Summary description for AnimatedProgressBarEx.
	/// </summary>
	public class AnimatedProgressBarEx : System.Windows.Forms.UserControl
	{
		private const int						maxSpeed = 20;

		private int								speed;
		private int								barWidth = 55;
		private int								lowerValue = 0;
		private int								upperValue = 0;

		private IC.Controls.ProgressBarEx progressBarEx;
		private System.Windows.Forms.Timer tmrAnim;
		private System.ComponentModel.IContainer components;

		public AnimatedProgressBarEx()
		{
			//this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);

			InitializeComponent();

            this.DoubleBuffered = true;

			this.Speed = 99;
		}

		public Color MinColor
		{
			get
			{
				return progressBarEx.MinColor;
			}
			set
			{
				progressBarEx.MinColor = value;
			}
		}

		public Color MaxColor
		{
			get
			{
				return progressBarEx.MaxColor;
			}
			set
			{
				progressBarEx.MaxColor = value;
			}
		}

		public int Speed
		{
			get
			{
				return speed;
			}
			set
			{
				if(value > 100)
					speed = 100;
				else if(value < 0)
					speed = 0;
				else
					speed = value;
			}
		}

		public void Start()
		{
			upperValue = 0;
			lowerValue = 0;

			tmrAnim.Start();
		}

		public void Stop()
		{
			tmrAnim.Stop();
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
			this.components = new System.ComponentModel.Container();
			this.progressBarEx = new IC.Controls.ProgressBarEx();
			this.tmrAnim = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// progressBarEx
			// 
			this.progressBarEx.Dock = System.Windows.Forms.DockStyle.Fill;
			this.progressBarEx.ForeColor = System.Drawing.Color.Gray;
			this.progressBarEx.Location = new System.Drawing.Point(0, 0);
			this.progressBarEx.LowerValue = 0;
			this.progressBarEx.MaxColor = System.Drawing.Color.Red;
			this.progressBarEx.MaxValue = 100;
			this.progressBarEx.MinColor = System.Drawing.Color.Gold;
			this.progressBarEx.MinValue = 0;
			this.progressBarEx.Name = "progressBarEx";
			this.progressBarEx.Size = new System.Drawing.Size(200, 8);
			this.progressBarEx.TabIndex = 0;
			this.progressBarEx.UpperValue = 0;
			// 
			// tmrAnim
			// 
			this.tmrAnim.Interval = 50;
			this.tmrAnim.Tick += new System.EventHandler(this.tmrAnim_Tick);
			// 
			// AnimatedProgressBarEx
			// 
			this.Controls.Add(this.progressBarEx);
			this.Name = "AnimatedProgressBarEx";
			this.Size = new System.Drawing.Size(200, 8);
			this.ResumeLayout(false);

		}
		#endregion

		private void tmrAnim_Tick(object sender, System.EventArgs e)
		{
			int incrementValue = (int)((float)speed / 100.0f * (float)maxSpeed);

			if(incrementValue <= 0)
				incrementValue = 1;

			upperValue += incrementValue;
			
			lowerValue = upperValue - barWidth;

			if(lowerValue > progressBarEx.MaxValue)
			{
				upperValue = 0;
				lowerValue = 0;
			}

			progressBarEx.UpperValue = upperValue;
			progressBarEx.LowerValue = lowerValue;
		}
	}
}
