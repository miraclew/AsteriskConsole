namespace VisualAsterisk.Main.UI.Forms
{
    partial class ConferenceEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConferenceEditorForm));
            IC.Controls.SmoothLabel roomNumberLabel;
            IC.Controls.SmoothLabel adminPinLabel;
            IC.Controls.SmoothLabel pinLabel;
            IC.Controls.SmoothLabel smoothLabel1;
            IC.Controls.SmoothLabel smoothLabel2;
            IC.Controls.SmoothLabel smoothLabel3;
            IC.Controls.SmoothLabel smoothLabel4;
            IC.Controls.SmoothLabel smoothLabel5;
            IC.Controls.SmoothLabel smoothLabel6;
            this.conferenceRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.waitformarkeduserCheckBox = new System.Windows.Forms.CheckBox();
            this.announcecallersCheckBox = new System.Windows.Forms.CheckBox();
            this.setmarkeduserCheckBox = new System.Windows.Forms.CheckBox();
            this.enablecallermenuCheckBox = new System.Windows.Forms.CheckBox();
            this.quietmodeCheckBox = new System.Windows.Forms.CheckBox();
            this.musicforfirstuserCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.adminPinTextBox = new System.Windows.Forms.TextBox();
            roomNumberLabel = new IC.Controls.SmoothLabel();
            adminPinLabel = new IC.Controls.SmoothLabel();
            pinLabel = new IC.Controls.SmoothLabel();
            smoothLabel1 = new IC.Controls.SmoothLabel();
            smoothLabel2 = new IC.Controls.SmoothLabel();
            smoothLabel3 = new IC.Controls.SmoothLabel();
            smoothLabel4 = new IC.Controls.SmoothLabel();
            smoothLabel5 = new IC.Controls.SmoothLabel();
            smoothLabel6 = new IC.Controls.SmoothLabel();
            this.contentPanel.SuspendLayout();
            this.buttomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conferenceRoomBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            resources.ApplyResources(this.headerPanel, "headerPanel");
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.groupBox2);
            this.contentPanel.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.contentPanel, "contentPanel");
            // 
            // buttomPanel
            // 
            resources.ApplyResources(this.buttomPanel, "buttomPanel");
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AntiAliasText = false;
            resources.ApplyResources(roomNumberLabel, "roomNumberLabel");
            roomNumberLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            roomNumberLabel.EnableHelp = true;
            roomNumberLabel.Name = "roomNumberLabel";
            // 
            // adminPinLabel
            // 
            adminPinLabel.AntiAliasText = false;
            resources.ApplyResources(adminPinLabel, "adminPinLabel");
            adminPinLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            adminPinLabel.EnableHelp = true;
            adminPinLabel.Name = "adminPinLabel";
            // 
            // pinLabel
            // 
            pinLabel.AntiAliasText = false;
            resources.ApplyResources(pinLabel, "pinLabel");
            pinLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            pinLabel.EnableHelp = true;
            pinLabel.Name = "pinLabel";
            // 
            // conferenceRoomBindingSource
            // 
            this.conferenceRoomBindingSource.DataSource = typeof(VisualAsterisk.Asterisk.Config.Configuration.ConferenceRoom);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(smoothLabel6);
            this.groupBox2.Controls.Add(smoothLabel5);
            this.groupBox2.Controls.Add(smoothLabel4);
            this.groupBox2.Controls.Add(smoothLabel3);
            this.groupBox2.Controls.Add(smoothLabel2);
            this.groupBox2.Controls.Add(smoothLabel1);
            this.groupBox2.Controls.Add(this.waitformarkeduserCheckBox);
            this.groupBox2.Controls.Add(this.announcecallersCheckBox);
            this.groupBox2.Controls.Add(this.setmarkeduserCheckBox);
            this.groupBox2.Controls.Add(this.enablecallermenuCheckBox);
            this.groupBox2.Controls.Add(this.quietmodeCheckBox);
            this.groupBox2.Controls.Add(this.musicforfirstuserCheckBox);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // waitformarkeduserCheckBox
            // 
            this.waitformarkeduserCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conferenceRoomBindingSource, "Waitformarkeduser", true));
            resources.ApplyResources(this.waitformarkeduserCheckBox, "waitformarkeduserCheckBox");
            this.waitformarkeduserCheckBox.Name = "waitformarkeduserCheckBox";
            this.waitformarkeduserCheckBox.UseVisualStyleBackColor = true;
            // 
            // announcecallersCheckBox
            // 
            this.announcecallersCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conferenceRoomBindingSource, "Announcecallers", true));
            resources.ApplyResources(this.announcecallersCheckBox, "announcecallersCheckBox");
            this.announcecallersCheckBox.Name = "announcecallersCheckBox";
            this.announcecallersCheckBox.UseVisualStyleBackColor = true;
            // 
            // setmarkeduserCheckBox
            // 
            this.setmarkeduserCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conferenceRoomBindingSource, "Setmarkeduser", true));
            resources.ApplyResources(this.setmarkeduserCheckBox, "setmarkeduserCheckBox");
            this.setmarkeduserCheckBox.Name = "setmarkeduserCheckBox";
            this.setmarkeduserCheckBox.UseVisualStyleBackColor = true;
            // 
            // enablecallermenuCheckBox
            // 
            this.enablecallermenuCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conferenceRoomBindingSource, "Enablecallermenu", true));
            resources.ApplyResources(this.enablecallermenuCheckBox, "enablecallermenuCheckBox");
            this.enablecallermenuCheckBox.Name = "enablecallermenuCheckBox";
            this.enablecallermenuCheckBox.UseVisualStyleBackColor = true;
            // 
            // quietmodeCheckBox
            // 
            this.quietmodeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conferenceRoomBindingSource, "Quietmode", true));
            resources.ApplyResources(this.quietmodeCheckBox, "quietmodeCheckBox");
            this.quietmodeCheckBox.Name = "quietmodeCheckBox";
            this.quietmodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // musicforfirstuserCheckBox
            // 
            this.musicforfirstuserCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.conferenceRoomBindingSource, "Musicforfirstuser", true));
            resources.ApplyResources(this.musicforfirstuserCheckBox, "musicforfirstuserCheckBox");
            this.musicforfirstuserCheckBox.Name = "musicforfirstuserCheckBox";
            this.musicforfirstuserCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(roomNumberLabel);
            this.groupBox1.Controls.Add(this.roomNumberTextBox);
            this.groupBox1.Controls.Add(adminPinLabel);
            this.groupBox1.Controls.Add(this.pinTextBox);
            this.groupBox1.Controls.Add(this.adminPinTextBox);
            this.groupBox1.Controls.Add(pinLabel);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conferenceRoomBindingSource, "RoomNumber", true));
            resources.ApplyResources(this.roomNumberTextBox, "roomNumberTextBox");
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            // 
            // pinTextBox
            // 
            this.pinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conferenceRoomBindingSource, "Pin", true));
            resources.ApplyResources(this.pinTextBox, "pinTextBox");
            this.pinTextBox.Name = "pinTextBox";
            // 
            // adminPinTextBox
            // 
            this.adminPinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conferenceRoomBindingSource, "AdminPin", true));
            resources.ApplyResources(this.adminPinTextBox, "adminPinTextBox");
            this.adminPinTextBox.Name = "adminPinTextBox";
            // 
            // smoothLabel1
            // 
            smoothLabel1.AntiAliasText = false;
            resources.ApplyResources(smoothLabel1, "smoothLabel1");
            smoothLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            smoothLabel1.EnableHelp = true;
            smoothLabel1.Name = "smoothLabel1";
            // 
            // smoothLabel2
            // 
            smoothLabel2.AntiAliasText = false;
            resources.ApplyResources(smoothLabel2, "smoothLabel2");
            smoothLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            smoothLabel2.EnableHelp = true;
            smoothLabel2.Name = "smoothLabel2";
            // 
            // smoothLabel3
            // 
            smoothLabel3.AntiAliasText = false;
            resources.ApplyResources(smoothLabel3, "smoothLabel3");
            smoothLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            smoothLabel3.EnableHelp = true;
            smoothLabel3.Name = "smoothLabel3";
            // 
            // smoothLabel4
            // 
            smoothLabel4.AntiAliasText = false;
            resources.ApplyResources(smoothLabel4, "smoothLabel4");
            smoothLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            smoothLabel4.EnableHelp = true;
            smoothLabel4.Name = "smoothLabel4";
            // 
            // smoothLabel5
            // 
            smoothLabel5.AntiAliasText = false;
            resources.ApplyResources(smoothLabel5, "smoothLabel5");
            smoothLabel5.Cursor = System.Windows.Forms.Cursors.Hand;
            smoothLabel5.EnableHelp = true;
            smoothLabel5.Name = "smoothLabel5";
            // 
            // smoothLabel6
            // 
            smoothLabel6.AntiAliasText = false;
            resources.ApplyResources(smoothLabel6, "smoothLabel6");
            smoothLabel6.Cursor = System.Windows.Forms.Cursors.Hand;
            smoothLabel6.EnableHelp = true;
            smoothLabel6.Name = "smoothLabel6";
            // 
            // ConferenceEditorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ConferenceEditorForm";
            this.contentPanel.ResumeLayout(false);
            this.buttomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.conferenceRoomBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource conferenceRoomBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox waitformarkeduserCheckBox;
        private System.Windows.Forms.CheckBox announcecallersCheckBox;
        private System.Windows.Forms.CheckBox setmarkeduserCheckBox;
        private System.Windows.Forms.CheckBox enablecallermenuCheckBox;
        private System.Windows.Forms.CheckBox quietmodeCheckBox;
        private System.Windows.Forms.CheckBox musicforfirstuserCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.TextBox adminPinTextBox;
    }
}