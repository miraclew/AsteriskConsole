using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualAsterisk.Main.Gui.AutoCompletion
{
    public partial class CompletionWindow : Form
    {
        public CompletionWindow(Point p, SimpleCompletionDataCollection memberlist, string lookAhead)
        {
            InitializeComponent();
            // Position the form
            this.StartPosition = FormStartPosition.Manual;
            this.Location = p;

            // Set column width to width of longest item
            listView.Columns[0].Width = -1;

            // Show the Members
            PopulateMemberList(memberlist, lookAhead);
            
        }
        
        protected override CreateParams CreateParams
        {
            get
            {
                // Hide the title bar
                CreateParams cp = base.CreateParams;
                cp.Style &= ~0xc00000; //WS_CAPTION;
                return cp;
            }
        }

        private void PopulateMemberList(SimpleCompletionDataCollection memberList, string lookAhead)
        {
            if (memberList == null) return;

            listView.BeginUpdate();

            foreach (SimpleCompletionData cd in memberList.CompletionDataCollection)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageKey = cd.Category.ToString();
                lvi.Text = cd.DisplayName;
                //lvi.ImageIndex = tm.Category;
                lvi.Tag = cd;
                //lvi.ToolTipText = FormatTooltip(cd);
                listView.Items.Add(lvi);
            }

            listView.EndUpdate();

            // Highlight the lookahead if we have one
            if ((lookAhead != null) && (listView.Items.Count > 0))
            {
                ListViewItem item = listView.FindItemWithText(lookAhead, false, 0, true);

                if (item != null)
                {
                    item.Selected = true;
                    item.Focused = true;
                    item.EnsureVisible();
                }
            }
        }

        private string FormatTooltip(ICompletionData cd)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            // Save the member Name
            memberText = listView.SelectedItems[0].Text;
            DialogResult = DialogResult.OK;
        }

        private void CompletionWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Back)
            {
                DialogResult = DialogResult.Cancel;
            }

            if (e.KeyCode == Keys.Enter ||
                e.KeyCode == Keys.Space)
            {
                if (listView.SelectedItems.Count == 0) return;

                // Save the member Name and insert text
                memberName = listView.SelectedItems[0].Text;

                SimpleCompletionData tm = listView.SelectedItems[0].Tag as SimpleCompletionData;
                if (tm == null)
                    memberText = memberName;
                else
                    memberText = tm.InsertName;

                DialogResult = DialogResult.OK;
            }

        }

        #region Properties

        private string memberName;
        internal string MemberName
        {
            get { return memberName; }
        }

        private string memberText;
        public string MemberText
        {
            get { return memberText; }
        }

        #endregion

    }
}