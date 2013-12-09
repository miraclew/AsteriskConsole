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



namespace IC.Controls.Wizard
{
    partial class WizardPageTabControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTab = new Controls.TabPanel();
            this.btnTabLink = new Controls.LinkButton();
            this.pnlTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTab
            // 
            this.pnlTab.BackColor = System.Drawing.Color.Transparent;
            this.pnlTab.BorderSize = 1F;
            this.pnlTab.Controls.Add(this.btnTabLink);
            this.pnlTab.CornerRadius = 5;
            this.pnlTab.DisplayShadow = false;
            this.pnlTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTab.ForeColor = System.Drawing.Color.DarkGray;
            this.pnlTab.Location = new System.Drawing.Point(0, 0);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pnlTab.PanelColor = System.Drawing.Color.White;
            this.pnlTab.Selected = false;
            this.pnlTab.ShadowColor = System.Drawing.Color.LightGray;
            this.pnlTab.ShadowOffset = 5;
            this.pnlTab.Size = new System.Drawing.Size(205, 30);
            this.pnlTab.TabIndex = 0;
            // 
            // btnTabLink
            // 
            this.btnTabLink.AntiAliasText = false;
            this.btnTabLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTabLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTabLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabLink.Location = new System.Drawing.Point(5, 0);
            this.btnTabLink.Name = "btnTabLink";
            this.btnTabLink.Size = new System.Drawing.Size(200, 30);
            this.btnTabLink.TabIndex = 0;
            this.btnTabLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabLink.UnderlineOnHover = true;
            // 
            // WizardPageTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTab);
            this.Name = "WizardPageTabControl";
            this.Size = new System.Drawing.Size(205, 30);
            this.pnlTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPanel pnlTab;
        private LinkButton btnTabLink;
    }
}
