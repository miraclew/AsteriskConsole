using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace VisualAsterisk.Manager.Controls
{
    public class VisualAsteriskEditDataGrid : VisualAsteriskDataGrid
    {
        public event EventHandler<DataRowEventArgs> EditDataRow;
        public event EventHandler<DataRowEventArgs> DeleteDataRow;

        private DataGridViewLinkColumn editColumn = null;
        private DataGridViewLinkColumn deleteColumn = null;
        private DataGridViewImageColumn rowImageColumn = null;
        private Image rowImage = null;

        private bool showEditColumn = true;
        private bool showDeleteColumn = true;

        public VisualAsteriskEditDataGrid()
        {
            this.MultiSelect = false;
        }

        protected override void InitLayout()
        {
            base.InitLayout();

            if (!DesignMode)
            {
                editColumn = new DataGridViewLinkColumn();
                editColumn.ActiveLinkColor = Color.RoyalBlue;
                editColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                editColumn.HeaderText = "";
                editColumn.LinkColor = Color.RoyalBlue;
                editColumn.TrackVisitedState = false;
                editColumn.UseColumnTextForLinkValue = true;
                editColumn.LinkBehavior = LinkBehavior.HoverUnderline;
                editColumn.Text = Properties.LocalizedStrings.Common_Edit;


                deleteColumn = new DataGridViewLinkColumn();
                deleteColumn.ActiveLinkColor = Color.RoyalBlue;
                deleteColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                deleteColumn.HeaderText = "";
                deleteColumn.LinkColor = Color.RoyalBlue;
                deleteColumn.TrackVisitedState = false;
                deleteColumn.UseColumnTextForLinkValue = true;
                deleteColumn.LinkBehavior = LinkBehavior.HoverUnderline;
                deleteColumn.Text = Properties.LocalizedStrings.Common_Delete;

                this.Columns.Add(editColumn);
                this.Columns.Add(deleteColumn);

                this.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(VisualAsteriskEditDataGrid_ColumnAdded);
            }
        }

        void VisualAsteriskEditDataGrid_ColumnAdded(object sender, System.Windows.Forms.DataGridViewColumnEventArgs e)
        {
            if (rowImageColumn != null)
                rowImageColumn.DisplayIndex = 0;

            editColumn.DisplayIndex = this.ColumnCount - 2;
            deleteColumn.DisplayIndex = this.ColumnCount - 1;
        }

        public bool ShowEditColumn
        {
            get
            {
                return showEditColumn;
            }
            set
            {
                showEditColumn = value;

                if (editColumn != null)
                    editColumn.Visible = value;
            }
        }

        public bool ShowDeleteColumn
        {
            get
            {
                return showDeleteColumn;
            }
            set
            {
                showDeleteColumn = value;

                if (deleteColumn != null)
                    deleteColumn.Visible = value;
            }
        }

        [TypeConverter(typeof(ImageConverter)), DefaultValue(typeof(Image), null), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image RowImage
        {
            get
            {
                return rowImage;
            }
            set
            {
                rowImage = value;

                if (!DesignMode)
                {
                    if (rowImage == null && rowImageColumn != null)
                        this.Columns.Remove(rowImageColumn);

                    rowImageColumn = null;

                    if (rowImage != null)
                    {
                        rowImageColumn = new DataGridViewImageColumn(false);
                        rowImageColumn.DisplayIndex = 0;
                        rowImageColumn.Image = rowImage;
                        rowImageColumn.Width = this.RowTemplate.Height;

                        this.Columns.Add(rowImageColumn);
                    }
                }
            }
        }

        protected override void OnCellContentClick(System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == editColumn.Index)
            {
                if (EditDataRow != null)
                    EditDataRow(this, new DataRowEventArgs(this.Rows[e.RowIndex]));
            }
            else if (e.ColumnIndex == deleteColumn.Index)
            {
                if (DeleteDataRow != null)
                    DeleteDataRow(this, new DataRowEventArgs(this.Rows[e.RowIndex]));
            }
            else
            {
                base.OnCellContentClick(e);
            }
        }

        protected override void OnCellDoubleClick(System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (EditDataRow != null && e.RowIndex >= 0 && e.RowIndex < this.Rows.Count)
                EditDataRow(this, new DataRowEventArgs(this.Rows[e.RowIndex]));

            base.OnCellDoubleClick(e);
        }
    }

    public class DataRowEventArgs : EventArgs
    {
        public DataGridViewRow DataRow = null;

        public DataRowEventArgs(DataGridViewRow dataRow)
        {
            DataRow = dataRow;
        }
    }

}
