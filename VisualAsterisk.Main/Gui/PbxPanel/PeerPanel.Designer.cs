namespace VisualAsterisk.Main.Gui.PbxPanel
{
    partial class PeerPanel
    {
        /// <summary>
        /// Required designer Variable.
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
            this.listViewPeers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewPeers
            // 
            this.listViewPeers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPeers.FullRowSelect = true;
            this.listViewPeers.Location = new System.Drawing.Point(0, 0);
            this.listViewPeers.Name = "listViewPeers";
            this.listViewPeers.Size = new System.Drawing.Size(456, 322);
            this.listViewPeers.TabIndex = 0;
            this.listViewPeers.UseCompatibleStateImageBehavior = false;
            this.listViewPeers.View = System.Windows.Forms.View.Details;
            this.listViewPeers.SelectedIndexChanged += new System.EventHandler(this.listViewPeers_SelectedIndexChanged);
            this.listViewPeers.DoubleClick += new System.EventHandler(this.listViewPeers_DoubleClick);
            // 
            // PeerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 322);
            this.Controls.Add(this.listViewPeers);
            this.Name = "PeerPanel";
            this.Text = "PeerPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPeers;
    }
}