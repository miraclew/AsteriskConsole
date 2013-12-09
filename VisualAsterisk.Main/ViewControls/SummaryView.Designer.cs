namespace VisualAsterisk.Main.ViewControls
{
    partial class SummaryView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param Name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryView));
            this.groupBoxEx1 = new IC.Controls.GroupBoxEx();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recentCallsPanel = new System.Windows.Forms.Panel();
            this.viewCallHistoryButton = new IC.Controls.LinkButton();
            this.callHistoryGroupBoxEx = new IC.Controls.GroupBoxEx();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCallsToday = new System.Windows.Forms.Label();
            this.lblCallsTotal = new System.Windows.Forms.Label();
            this.lblCallsMonth = new System.Windows.Forms.Label();
            this.lblCallsWeek = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBoxEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.callHistoryGroupBoxEx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEx1
            // 
            this.groupBoxEx1.AntiAliasText = false;
            this.groupBoxEx1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxEx1.Controls.Add(this.pictureBox1);
            this.groupBoxEx1.Controls.Add(this.recentCallsPanel);
            this.groupBoxEx1.Controls.Add(this.viewCallHistoryButton);
            this.groupBoxEx1.CornerRadius = 10;
            this.groupBoxEx1.DividerAbove = false;
            resources.ApplyResources(this.groupBoxEx1, "groupBoxEx1");
            this.groupBoxEx1.DrawLeftDivider = false;
            this.groupBoxEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.groupBoxEx1.HeaderColor = System.Drawing.Color.Gray;
            this.groupBoxEx1.Name = "groupBoxEx1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::VisualAsterisk.Main.Properties.Resources.telephone_24;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // recentCallsPanel
            // 
            resources.ApplyResources(this.recentCallsPanel, "recentCallsPanel");
            this.recentCallsPanel.Name = "recentCallsPanel";
            // 
            // viewCallHistoryButton
            // 
            this.viewCallHistoryButton.AntiAliasText = false;
            resources.ApplyResources(this.viewCallHistoryButton, "viewCallHistoryButton");
            this.viewCallHistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewCallHistoryButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.viewCallHistoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewCallHistoryButton.LinkImage = global::VisualAsterisk.Main.Properties.Resources.view_16;
            this.viewCallHistoryButton.Name = "viewCallHistoryButton";
            this.viewCallHistoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewCallHistoryButton.UnderlineOnHover = true;
            this.viewCallHistoryButton.Click += new System.EventHandler(this.viewCallHistoryButton_Click);
            // 
            // callHistoryGroupBoxEx
            // 
            this.callHistoryGroupBoxEx.AntiAliasText = false;
            this.callHistoryGroupBoxEx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.callHistoryGroupBoxEx.Controls.Add(this.pictureBox2);
            this.callHistoryGroupBoxEx.Controls.Add(this.panel2);
            this.callHistoryGroupBoxEx.CornerRadius = 10;
            this.callHistoryGroupBoxEx.DividerAbove = false;
            resources.ApplyResources(this.callHistoryGroupBoxEx, "callHistoryGroupBoxEx");
            this.callHistoryGroupBoxEx.DrawLeftDivider = false;
            this.callHistoryGroupBoxEx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.callHistoryGroupBoxEx.HeaderColor = System.Drawing.Color.Gray;
            this.callHistoryGroupBoxEx.Name = "callHistoryGroupBoxEx";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::VisualAsterisk.Main.Properties.Resources.column_chart_24;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCallsToday);
            this.panel2.Controls.Add(this.lblCallsTotal);
            this.panel2.Controls.Add(this.lblCallsMonth);
            this.panel2.Controls.Add(this.lblCallsWeek);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.panel2.Name = "panel2";
            // 
            // lblCallsToday
            // 
            resources.ApplyResources(this.lblCallsToday, "lblCallsToday");
            this.lblCallsToday.Name = "lblCallsToday";
            // 
            // lblCallsTotal
            // 
            resources.ApplyResources(this.lblCallsTotal, "lblCallsTotal");
            this.lblCallsTotal.Name = "lblCallsTotal";
            // 
            // lblCallsMonth
            // 
            resources.ApplyResources(this.lblCallsMonth, "lblCallsMonth");
            this.lblCallsMonth.Name = "lblCallsMonth";
            // 
            // lblCallsWeek
            // 
            resources.ApplyResources(this.lblCallsWeek, "lblCallsWeek");
            this.lblCallsWeek.Name = "lblCallsWeek";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.groupBoxEx1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.callHistoryGroupBoxEx, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // SummaryView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.HeaderIcon = global::VisualAsterisk.Main.Properties.Resources.gear_find_48_shadow;
            this.Name = "SummaryView";
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBoxEx1.ResumeLayout(false);
            this.groupBoxEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.callHistoryGroupBoxEx.ResumeLayout(false);
            this.callHistoryGroupBoxEx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private IC.Controls.GroupBoxEx groupBoxEx1;
        private IC.Controls.GroupBoxEx callHistoryGroupBoxEx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel recentCallsPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private IC.Controls.LinkButton viewCallHistoryButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCallsToday;
        private System.Windows.Forms.Label lblCallsTotal;
        private System.Windows.Forms.Label lblCallsMonth;
        private System.Windows.Forms.Label lblCallsWeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
