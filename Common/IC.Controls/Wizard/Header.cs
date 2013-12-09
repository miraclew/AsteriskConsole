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

namespace IC.Controls.Wizard
{
	/// <summary>
	/// Summary description for WizardHeader.
	/// </summary>
	[Designer(typeof(HeaderDesigner))]
	public class Header : UserControl
	{
        private System.Windows.Forms.Panel pnlDockPadding;
		private System.Windows.Forms.PictureBox picIcon;
		private System.Windows.Forms.Panel pnl3dDark;
		private System.Windows.Forms.Panel pnl3dBright;
        private Label lblDescription;
        private Label lblTitle;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Constructor for Header
		/// </summary>
		public Header()
		{
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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.pnlDockPadding = new System.Windows.Forms.Panel();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.pnl3dDark = new System.Windows.Forms.Panel();
            this.pnl3dBright = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlDockPadding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDockPadding
            // 
            this.pnlDockPadding.Controls.Add(this.lblDescription);
            this.pnlDockPadding.Controls.Add(this.lblTitle);
            this.pnlDockPadding.Controls.Add(this.picIcon);
            this.pnlDockPadding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDockPadding.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDockPadding.Location = new System.Drawing.Point(0, 0);
            this.pnlDockPadding.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pnlDockPadding.Name = "pnlDockPadding";
            this.pnlDockPadding.Padding = new System.Windows.Forms.Padding(8, 6, 4, 4);
            this.pnlDockPadding.Size = new System.Drawing.Size(324, 64);
            this.pnlDockPadding.TabIndex = 6;
            // 
            // picIcon
            // 
            this.picIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.picIcon.Location = new System.Drawing.Point(268, 6);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(52, 54);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            this.picIcon.Visible = false;
            // 
            // pnl3dDark
            // 
            this.pnl3dDark.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl3dDark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl3dDark.Location = new System.Drawing.Point(0, 62);
            this.pnl3dDark.Name = "pnl3dDark";
            this.pnl3dDark.Size = new System.Drawing.Size(324, 1);
            this.pnl3dDark.TabIndex = 7;
            // 
            // pnl3dBright
            // 
            this.pnl3dBright.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl3dBright.Location = new System.Drawing.Point(0, 63);
            this.pnl3dBright.Name = "pnl3dBright";
            this.pnl3dBright.Size = new System.Drawing.Size(324, 1);
            this.pnl3dBright.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(8, 6);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 15);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(8, 21);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(260, 39);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // Header
            // 
            this.CausesValidation = false;
            this.Controls.Add(this.pnl3dDark);
            this.Controls.Add(this.pnl3dBright);
            this.Controls.Add(this.pnlDockPadding);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(324, 64);
            this.pnlDockPadding.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Get/Set the title for the wizard page
		/// </summary>
		[Category("Appearance")]
        [Localizable(true)]
		public string Title
		{
			get
			{
				return lblTitle.Text;
			}
			set
			{
				lblTitle.Text = value;
			}
		}

		/// <summary>
		/// Gets/Sets the
		/// </summary>
		[Category("Appearance")]
        [Localizable(true)]
		public string Description
		{
			get
			{
				return lblDescription.Text;
			}
			set
			{
				lblDescription.Text = value;
			}
		}

		/// <summary>
		/// Gets/Sets the Icon
		/// </summary>
		[Category("Appearance")]
        [TypeConverter(typeof(ImageConverter)), DefaultValue(typeof(Image), null), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public Image Image
		{
			get
			{
				return picIcon.Image;
			}
			set
			{
				picIcon.Image = value;

                if (value != null)
                    picIcon.Visible = true;
                else
                    picIcon.Visible = false;
			}
		}
	}
}
