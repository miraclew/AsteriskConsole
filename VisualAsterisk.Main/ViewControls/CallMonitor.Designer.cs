namespace VisualAsterisk.Main.ViewControls
{
    partial class CallMonitor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallMonitor));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewExtensions = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listViewTrunks = new System.Windows.Forms.ListView();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader19 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader20 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader21 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader22 = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewPackinglots = new System.Windows.Forms.ListView();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewQueues = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewConferences = new System.Windows.Forms.ListView();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usersImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoProvider
            // 
            resources.ApplyResources(this.infoProvider, "infoProvider");
            // 
            // errorProvider
            // 
            resources.ApplyResources(this.errorProvider, "errorProvider");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AccessibleDescription = null;
            this.tableLayoutPanel1.AccessibleName = null;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackgroundImage = null;
            this.tableLayoutPanel1.Controls.Add(this.listViewExtensions, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listViewTrunks, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.listViewPackinglots, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.listViewQueues, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.listViewConferences, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.errorProvider.SetError(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.Error"));
            this.infoProvider.SetError(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.Error1"));
            this.tableLayoutPanel1.Font = null;
            this.infoProvider.SetIconAlignment(this.tableLayoutPanel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tableLayoutPanel1.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.tableLayoutPanel1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("tableLayoutPanel1.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.tableLayoutPanel1, ((int)(resources.GetObject("tableLayoutPanel1.IconPadding"))));
            this.infoProvider.SetIconPadding(this.tableLayoutPanel1, ((int)(resources.GetObject("tableLayoutPanel1.IconPadding1"))));
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.toolTip.SetToolTip(this.tableLayoutPanel1, resources.GetString("tableLayoutPanel1.ToolTip"));
            // 
            // listViewExtensions
            // 
            this.listViewExtensions.AccessibleDescription = null;
            this.listViewExtensions.AccessibleName = null;
            resources.ApplyResources(this.listViewExtensions, "listViewExtensions");
            this.listViewExtensions.BackgroundImage = null;
            this.listViewExtensions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.errorProvider.SetError(this.listViewExtensions, resources.GetString("listViewExtensions.Error"));
            this.infoProvider.SetError(this.listViewExtensions, resources.GetString("listViewExtensions.Error1"));
            this.listViewExtensions.Font = null;
            this.listViewExtensions.FullRowSelect = true;
            this.infoProvider.SetIconAlignment(this.listViewExtensions, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("listViewExtensions.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.listViewExtensions, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("listViewExtensions.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.listViewExtensions, ((int)(resources.GetObject("listViewExtensions.IconPadding"))));
            this.infoProvider.SetIconPadding(this.listViewExtensions, ((int)(resources.GetObject("listViewExtensions.IconPadding1"))));
            this.listViewExtensions.Name = "listViewExtensions";
            this.tableLayoutPanel1.SetRowSpan(this.listViewExtensions, 7);
            this.listViewExtensions.SmallImageList = this.imageList1;
            this.toolTip.SetToolTip(this.listViewExtensions, resources.GetString("listViewExtensions.ToolTip"));
            this.listViewExtensions.UseCompatibleStateImageBehavior = false;
            this.listViewExtensions.View = System.Windows.Forms.View.Details;
            this.listViewExtensions.DoubleClick += new System.EventHandler(this.listViewExtensions_DoubleClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "01.png");
            this.imageList1.Images.SetKeyName(1, "02.png");
            this.imageList1.Images.SetKeyName(2, "03.png");
            this.imageList1.Images.SetKeyName(3, "04.png");
            this.imageList1.Images.SetKeyName(4, "05.png");
            this.imageList1.Images.SetKeyName(5, "06.png");
            this.imageList1.Images.SetKeyName(6, "07.png");
            this.imageList1.Images.SetKeyName(7, "08.png");
            this.imageList1.Images.SetKeyName(8, "09.png");
            this.imageList1.Images.SetKeyName(9, "10.png");
            this.imageList1.Images.SetKeyName(10, "11.png");
            // 
            // listViewTrunks
            // 
            this.listViewTrunks.AccessibleDescription = null;
            this.listViewTrunks.AccessibleName = null;
            resources.ApplyResources(this.listViewTrunks, "listViewTrunks");
            this.listViewTrunks.BackgroundImage = null;
            this.listViewTrunks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
            this.errorProvider.SetError(this.listViewTrunks, resources.GetString("listViewTrunks.Error"));
            this.infoProvider.SetError(this.listViewTrunks, resources.GetString("listViewTrunks.Error1"));
            this.listViewTrunks.Font = null;
            this.listViewTrunks.FullRowSelect = true;
            this.infoProvider.SetIconAlignment(this.listViewTrunks, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("listViewTrunks.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.listViewTrunks, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("listViewTrunks.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.listViewTrunks, ((int)(resources.GetObject("listViewTrunks.IconPadding"))));
            this.infoProvider.SetIconPadding(this.listViewTrunks, ((int)(resources.GetObject("listViewTrunks.IconPadding1"))));
            this.listViewTrunks.Name = "listViewTrunks";
            this.listViewTrunks.SmallImageList = this.imageList1;
            this.toolTip.SetToolTip(this.listViewTrunks, resources.GetString("listViewTrunks.ToolTip"));
            this.listViewTrunks.UseCompatibleStateImageBehavior = false;
            this.listViewTrunks.View = System.Windows.Forms.View.Details;
            this.listViewTrunks.DoubleClick += new System.EventHandler(this.listViewTrunks_DoubleClick);
            // 
            // columnHeader17
            // 
            resources.ApplyResources(this.columnHeader17, "columnHeader17");
            // 
            // columnHeader18
            // 
            resources.ApplyResources(this.columnHeader18, "columnHeader18");
            // 
            // columnHeader19
            // 
            resources.ApplyResources(this.columnHeader19, "columnHeader19");
            // 
            // columnHeader20
            // 
            resources.ApplyResources(this.columnHeader20, "columnHeader20");
            // 
            // columnHeader21
            // 
            resources.ApplyResources(this.columnHeader21, "columnHeader21");
            // 
            // columnHeader22
            // 
            resources.ApplyResources(this.columnHeader22, "columnHeader22");
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.errorProvider.SetError(this.label4, resources.GetString("label4.Error"));
            this.infoProvider.SetError(this.label4, resources.GetString("label4.Error1"));
            this.label4.Font = null;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.infoProvider.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.infoProvider.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding1"))));
            this.label4.Name = "label4";
            this.toolTip.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // listViewPackinglots
            // 
            this.listViewPackinglots.AccessibleDescription = null;
            this.listViewPackinglots.AccessibleName = null;
            resources.ApplyResources(this.listViewPackinglots, "listViewPackinglots");
            this.listViewPackinglots.BackgroundImage = null;
            this.listViewPackinglots.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.errorProvider.SetError(this.listViewPackinglots, resources.GetString("listViewPackinglots.Error"));
            this.infoProvider.SetError(this.listViewPackinglots, resources.GetString("listViewPackinglots.Error1"));
            this.listViewPackinglots.Font = null;
            this.listViewPackinglots.FullRowSelect = true;
            this.infoProvider.SetIconAlignment(this.listViewPackinglots, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("listViewPackinglots.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.listViewPackinglots, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("listViewPackinglots.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.listViewPackinglots, ((int)(resources.GetObject("listViewPackinglots.IconPadding"))));
            this.infoProvider.SetIconPadding(this.listViewPackinglots, ((int)(resources.GetObject("listViewPackinglots.IconPadding1"))));
            this.listViewPackinglots.Name = "listViewPackinglots";
            this.listViewPackinglots.SmallImageList = this.imageList1;
            this.toolTip.SetToolTip(this.listViewPackinglots, resources.GetString("listViewPackinglots.ToolTip"));
            this.listViewPackinglots.UseCompatibleStateImageBehavior = false;
            this.listViewPackinglots.View = System.Windows.Forms.View.Details;
            this.listViewPackinglots.DoubleClick += new System.EventHandler(this.listViewPackinglots_DoubleClick);
            // 
            // columnHeader12
            // 
            resources.ApplyResources(this.columnHeader12, "columnHeader12");
            // 
            // columnHeader13
            // 
            resources.ApplyResources(this.columnHeader13, "columnHeader13");
            // 
            // columnHeader14
            // 
            resources.ApplyResources(this.columnHeader14, "columnHeader14");
            // 
            // columnHeader15
            // 
            resources.ApplyResources(this.columnHeader15, "columnHeader15");
            // 
            // columnHeader16
            // 
            resources.ApplyResources(this.columnHeader16, "columnHeader16");
            // 
            // label5
            // 
            this.label5.AccessibleDescription = null;
            this.label5.AccessibleName = null;
            resources.ApplyResources(this.label5, "label5");
            this.errorProvider.SetError(this.label5, resources.GetString("label5.Error"));
            this.infoProvider.SetError(this.label5, resources.GetString("label5.Error1"));
            this.label5.Font = null;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.infoProvider.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.infoProvider.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding1"))));
            this.label5.Name = "label5";
            this.toolTip.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // listViewQueues
            // 
            this.listViewQueues.AccessibleDescription = null;
            this.listViewQueues.AccessibleName = null;
            resources.ApplyResources(this.listViewQueues, "listViewQueues");
            this.listViewQueues.BackgroundImage = null;
            this.listViewQueues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.errorProvider.SetError(this.listViewQueues, resources.GetString("listViewQueues.Error"));
            this.infoProvider.SetError(this.listViewQueues, resources.GetString("listViewQueues.Error1"));
            this.listViewQueues.Font = null;
            this.listViewQueues.FullRowSelect = true;
            this.infoProvider.SetIconAlignment(this.listViewQueues, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("listViewQueues.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.listViewQueues, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("listViewQueues.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.listViewQueues, ((int)(resources.GetObject("listViewQueues.IconPadding"))));
            this.infoProvider.SetIconPadding(this.listViewQueues, ((int)(resources.GetObject("listViewQueues.IconPadding1"))));
            this.listViewQueues.Name = "listViewQueues";
            this.listViewQueues.SmallImageList = this.imageList1;
            this.toolTip.SetToolTip(this.listViewQueues, resources.GetString("listViewQueues.ToolTip"));
            this.listViewQueues.UseCompatibleStateImageBehavior = false;
            this.listViewQueues.View = System.Windows.Forms.View.Details;
            this.listViewQueues.DoubleClick += new System.EventHandler(this.listViewQueues_DoubleClick);
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // columnHeader8
            // 
            resources.ApplyResources(this.columnHeader8, "columnHeader8");
            // 
            // columnHeader9
            // 
            resources.ApplyResources(this.columnHeader9, "columnHeader9");
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.errorProvider.SetError(this.label3, resources.GetString("label3.Error"));
            this.infoProvider.SetError(this.label3, resources.GetString("label3.Error1"));
            this.label3.Font = null;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.infoProvider.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.infoProvider.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding1"))));
            this.label3.Name = "label3";
            this.toolTip.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // listViewConferences
            // 
            this.listViewConferences.AccessibleDescription = null;
            this.listViewConferences.AccessibleName = null;
            resources.ApplyResources(this.listViewConferences, "listViewConferences");
            this.listViewConferences.BackgroundImage = null;
            this.listViewConferences.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11});
            this.errorProvider.SetError(this.listViewConferences, resources.GetString("listViewConferences.Error"));
            this.infoProvider.SetError(this.listViewConferences, resources.GetString("listViewConferences.Error1"));
            this.listViewConferences.Font = null;
            this.listViewConferences.FullRowSelect = true;
            this.infoProvider.SetIconAlignment(this.listViewConferences, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("listViewConferences.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.listViewConferences, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("listViewConferences.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.listViewConferences, ((int)(resources.GetObject("listViewConferences.IconPadding"))));
            this.infoProvider.SetIconPadding(this.listViewConferences, ((int)(resources.GetObject("listViewConferences.IconPadding1"))));
            this.listViewConferences.Name = "listViewConferences";
            this.listViewConferences.SmallImageList = this.imageList1;
            this.toolTip.SetToolTip(this.listViewConferences, resources.GetString("listViewConferences.ToolTip"));
            this.listViewConferences.UseCompatibleStateImageBehavior = false;
            this.listViewConferences.View = System.Windows.Forms.View.Details;
            this.listViewConferences.DoubleClick += new System.EventHandler(this.listViewConferences_DoubleClick);
            // 
            // columnHeader10
            // 
            resources.ApplyResources(this.columnHeader10, "columnHeader10");
            // 
            // columnHeader11
            // 
            resources.ApplyResources(this.columnHeader11, "columnHeader11");
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider.SetError(this.label2, resources.GetString("label2.Error"));
            this.infoProvider.SetError(this.label2, resources.GetString("label2.Error1"));
            this.label2.Font = null;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.infoProvider.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.infoProvider.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding1"))));
            this.label2.Name = "label2";
            this.toolTip.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider.SetError(this.label1, resources.GetString("label1.Error"));
            this.infoProvider.SetError(this.label1, resources.GetString("label1.Error1"));
            this.label1.Font = null;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.infoProvider.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.infoProvider.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding1"))));
            this.label1.Name = "label1";
            this.toolTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // usersImageList
            // 
            this.usersImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("usersImageList.ImageStream")));
            this.usersImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.usersImageList.Images.SetKeyName(0, "01.png");
            this.usersImageList.Images.SetKeyName(1, "02.png");
            this.usersImageList.Images.SetKeyName(2, "03.png");
            this.usersImageList.Images.SetKeyName(3, "04.png");
            this.usersImageList.Images.SetKeyName(4, "05.png");
            this.usersImageList.Images.SetKeyName(5, "06.png");
            this.usersImageList.Images.SetKeyName(6, "07.png");
            this.usersImageList.Images.SetKeyName(7, "08.png");
            this.usersImageList.Images.SetKeyName(8, "09.png");
            this.usersImageList.Images.SetKeyName(9, "10.png");
            this.usersImageList.Images.SetKeyName(10, "11.png");
            // 
            // CallMonitor
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.tableLayoutPanel1);
            this.errorProvider.SetError(this, resources.GetString("$this.Error"));
            this.infoProvider.SetError(this, resources.GetString("$this.Error1"));
            this.HeaderIcon = global::VisualAsterisk.Main.Properties.Resources.multiple_monitors_48;
            this.infoProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorProvider.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment1"))));
            this.errorProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.infoProvider.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding1"))));
            this.Name = "CallMonitor";
            this.toolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listViewExtensions;
        private System.Windows.Forms.ListView listViewTrunks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewPackinglots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewQueues;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewConferences;
        private System.Windows.Forms.ImageList usersImageList;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}