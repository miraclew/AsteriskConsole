using Asterisk.NET.Manager.Event;
namespace VisualAsterisk.Main.ViewControls
{
    partial class CallDetailRecordView
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallDetailRecordView));
            this.cdrDataSet = new VisualAsterisk.Data.VisualAsteriskDataSet();
            this.cdrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visualAsteriskDataGrid1 = new VisualAsterisk.Manager.Controls.VisualAsteriskDataGrid();
            this.accountCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationContextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.callerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationChannelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastApplicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billableSecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amaFlagsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualAsteriskDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttomPanel
            // 
            resources.ApplyResources(this.buttomPanel, "buttomPanel");
            // 
            // topPanel
            // 
            resources.ApplyResources(this.topPanel, "topPanel");
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.visualAsteriskDataGrid1);
            resources.ApplyResources(this.contentPanel, "contentPanel");
            // 
            // cdrDataSet
            // 
            this.cdrDataSet.DataSetName = "VisualAsteriskDataSet";
            this.cdrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cdrBindingSource
            // 
            this.cdrBindingSource.DataMember = "CallDetailRecord";
            this.cdrBindingSource.DataSource = this.cdrDataSet;
            // 
            // visualAsteriskDataGrid1
            // 
            this.visualAsteriskDataGrid1.AllowUserToAddRows = false;
            this.visualAsteriskDataGrid1.AllowUserToDeleteRows = false;
            this.visualAsteriskDataGrid1.AllowUserToResizeRows = false;
            this.visualAsteriskDataGrid1.AutoGenerateColumns = false;
            this.visualAsteriskDataGrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.visualAsteriskDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.visualAsteriskDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.visualAsteriskDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.visualAsteriskDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visualAsteriskDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountCodeDataGridViewTextBoxColumn,
            this.srcDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.destinationContextDataGridViewTextBoxColumn,
            this.callerIdDataGridViewTextBoxColumn,
            this.destinationChannelDataGridViewTextBoxColumn,
            this.lastApplicationDataGridViewTextBoxColumn,
            this.lastDataDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.answerTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.billableSecondsDataGridViewTextBoxColumn,
            this.dispositionDataGridViewTextBoxColumn,
            this.amaFlagsDataGridViewTextBoxColumn,
            this.userFieldDataGridViewTextBoxColumn});
            this.visualAsteriskDataGrid1.DataSource = this.cdrBindingSource;
            resources.ApplyResources(this.visualAsteriskDataGrid1, "visualAsteriskDataGrid1");
            this.visualAsteriskDataGrid1.Name = "visualAsteriskDataGrid1";
            this.visualAsteriskDataGrid1.ReadOnly = true;
            this.visualAsteriskDataGrid1.RowHeadersVisible = false;
            this.visualAsteriskDataGrid1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.visualAsteriskDataGrid1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.visualAsteriskDataGrid1.RowTemplate.Height = 32;
            this.visualAsteriskDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // accountCodeDataGridViewTextBoxColumn
            // 
            this.accountCodeDataGridViewTextBoxColumn.DataPropertyName = "AccountCode";
            resources.ApplyResources(this.accountCodeDataGridViewTextBoxColumn, "accountCodeDataGridViewTextBoxColumn");
            this.accountCodeDataGridViewTextBoxColumn.Name = "accountCodeDataGridViewTextBoxColumn";
            this.accountCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // srcDataGridViewTextBoxColumn
            // 
            this.srcDataGridViewTextBoxColumn.DataPropertyName = "Src";
            resources.ApplyResources(this.srcDataGridViewTextBoxColumn, "srcDataGridViewTextBoxColumn");
            this.srcDataGridViewTextBoxColumn.Name = "srcDataGridViewTextBoxColumn";
            this.srcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            resources.ApplyResources(this.destinationDataGridViewTextBoxColumn, "destinationDataGridViewTextBoxColumn");
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationContextDataGridViewTextBoxColumn
            // 
            this.destinationContextDataGridViewTextBoxColumn.DataPropertyName = "DestinationContext";
            resources.ApplyResources(this.destinationContextDataGridViewTextBoxColumn, "destinationContextDataGridViewTextBoxColumn");
            this.destinationContextDataGridViewTextBoxColumn.Name = "destinationContextDataGridViewTextBoxColumn";
            this.destinationContextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // callerIdDataGridViewTextBoxColumn
            // 
            this.callerIdDataGridViewTextBoxColumn.DataPropertyName = "CallerId";
            resources.ApplyResources(this.callerIdDataGridViewTextBoxColumn, "callerIdDataGridViewTextBoxColumn");
            this.callerIdDataGridViewTextBoxColumn.Name = "callerIdDataGridViewTextBoxColumn";
            this.callerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationChannelDataGridViewTextBoxColumn
            // 
            this.destinationChannelDataGridViewTextBoxColumn.DataPropertyName = "DestinationChannel";
            resources.ApplyResources(this.destinationChannelDataGridViewTextBoxColumn, "destinationChannelDataGridViewTextBoxColumn");
            this.destinationChannelDataGridViewTextBoxColumn.Name = "destinationChannelDataGridViewTextBoxColumn";
            this.destinationChannelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastApplicationDataGridViewTextBoxColumn
            // 
            this.lastApplicationDataGridViewTextBoxColumn.DataPropertyName = "LastApplication";
            resources.ApplyResources(this.lastApplicationDataGridViewTextBoxColumn, "lastApplicationDataGridViewTextBoxColumn");
            this.lastApplicationDataGridViewTextBoxColumn.Name = "lastApplicationDataGridViewTextBoxColumn";
            this.lastApplicationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastDataDataGridViewTextBoxColumn
            // 
            this.lastDataDataGridViewTextBoxColumn.DataPropertyName = "LastData";
            resources.ApplyResources(this.lastDataDataGridViewTextBoxColumn, "lastDataDataGridViewTextBoxColumn");
            this.lastDataDataGridViewTextBoxColumn.Name = "lastDataDataGridViewTextBoxColumn";
            this.lastDataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            resources.ApplyResources(this.startTimeDataGridViewTextBoxColumn, "startTimeDataGridViewTextBoxColumn");
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // answerTimeDataGridViewTextBoxColumn
            // 
            this.answerTimeDataGridViewTextBoxColumn.DataPropertyName = "AnswerTime";
            resources.ApplyResources(this.answerTimeDataGridViewTextBoxColumn, "answerTimeDataGridViewTextBoxColumn");
            this.answerTimeDataGridViewTextBoxColumn.Name = "answerTimeDataGridViewTextBoxColumn";
            this.answerTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            resources.ApplyResources(this.endTimeDataGridViewTextBoxColumn, "endTimeDataGridViewTextBoxColumn");
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            resources.ApplyResources(this.durationDataGridViewTextBoxColumn, "durationDataGridViewTextBoxColumn");
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billableSecondsDataGridViewTextBoxColumn
            // 
            this.billableSecondsDataGridViewTextBoxColumn.DataPropertyName = "BillableSeconds";
            resources.ApplyResources(this.billableSecondsDataGridViewTextBoxColumn, "billableSecondsDataGridViewTextBoxColumn");
            this.billableSecondsDataGridViewTextBoxColumn.Name = "billableSecondsDataGridViewTextBoxColumn";
            this.billableSecondsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dispositionDataGridViewTextBoxColumn
            // 
            this.dispositionDataGridViewTextBoxColumn.DataPropertyName = "Disposition";
            resources.ApplyResources(this.dispositionDataGridViewTextBoxColumn, "dispositionDataGridViewTextBoxColumn");
            this.dispositionDataGridViewTextBoxColumn.Name = "dispositionDataGridViewTextBoxColumn";
            this.dispositionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amaFlagsDataGridViewTextBoxColumn
            // 
            this.amaFlagsDataGridViewTextBoxColumn.DataPropertyName = "AmaFlags";
            resources.ApplyResources(this.amaFlagsDataGridViewTextBoxColumn, "amaFlagsDataGridViewTextBoxColumn");
            this.amaFlagsDataGridViewTextBoxColumn.Name = "amaFlagsDataGridViewTextBoxColumn";
            this.amaFlagsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userFieldDataGridViewTextBoxColumn
            // 
            this.userFieldDataGridViewTextBoxColumn.DataPropertyName = "UserField";
            resources.ApplyResources(this.userFieldDataGridViewTextBoxColumn, "userFieldDataGridViewTextBoxColumn");
            this.userFieldDataGridViewTextBoxColumn.Name = "userFieldDataGridViewTextBoxColumn";
            this.userFieldDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CallDetailRecordView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.HeaderIcon = global::VisualAsterisk.Main.Properties.Resources.cal_48;
            this.Name = "CallDetailRecordView";
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualAsteriskDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VisualAsterisk.Data.VisualAsteriskDataSet cdrDataSet;
        private System.Windows.Forms.BindingSource cdrBindingSource;
        private VisualAsterisk.Manager.Controls.VisualAsteriskDataGrid visualAsteriskDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn srcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationContextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn callerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationChannelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastApplicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billableSecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amaFlagsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFieldDataGridViewTextBoxColumn;


    }
}
