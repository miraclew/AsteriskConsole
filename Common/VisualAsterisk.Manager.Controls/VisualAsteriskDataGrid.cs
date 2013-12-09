using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace VisualAsterisk.Manager.Controls
{
    public class VisualAsteriskDataGrid : DataGridView
    {
        public VisualAsteriskDataGrid()
        {
            this.BackgroundColor = Color.WhiteSmoke;
            this.BorderStyle = BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.RowHeadersVisible = false;
            this.RowTemplate.Height = 32;
            this.RowTemplate.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            this.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.AllowUserToResizeRows = false;
            this.AllowUserToResizeColumns = true;
            this.ReadOnly = true;
            this.AllowUserToAddRows = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CallButlerDataGrid
            // 
            this.AllowUserToDeleteRows = false;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
