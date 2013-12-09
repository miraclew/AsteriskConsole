using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Main;
using System.Reflection;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Main.Controller;
using VisualAsterisk.Main.ViewControls;
using VisualAsterisk.Main.UI;
using AstFileEditor;


namespace VisualAsterisk.Test.UI
{
    public partial class FormTestRuner : Form
    {
        private Dictionary<string, Type> m_TestCaseTypes;
        public FormTestRuner()
        {
            InitializeComponent();
            autoConneectCheckBox.Checked = Properties.Settings.Default.AutoConnect;

            loadTestAssembly();
            if (Properties.Settings.Default.AutoConnect)
            {
                connect();
            }
        }

        private void initial()
        {
            Assembly assembly = Assembly.LoadFile(@"D:\Project\VisualAsterisk\VisualAsterisk.Main\bin\Debug\VisualAsterisk.exe");
            Type[] types = assembly.GetTypes();
            m_TestCaseTypes = new Dictionary<string, Type>();
            foreach (Type type in types)
            {
                if (type.IsSubclassOf(typeof(AbstractUITestCase)))
                {
                    m_TestCaseTypes[type.Name] = type;
                    AbstractUITestCase testCase = type.GetConstructor(Type.EmptyTypes).Invoke(null) as AbstractUITestCase;
                    ListViewItem item = new ListViewItem(new string[] { testCase.Name, testCase.Description, testCase.Namespace });
                    item.Tag = type;
                    testcasesListView.Items.Add(item);
                }
            }
        }

        private void loadTestAssembly()
        {
            testcasesListView.Items.Clear();
            testcasesListView.Groups.Clear();
            //Assembly assembly = Assembly.LoadFile(@"D:\Project\VisualAsterisk\VisualAsterisk.Main\bin\Debug\VisualAsterisk.exe");
            List<Type> types = new List<Type>();
            types.AddRange(Assembly.GetAssembly(typeof(MainForm)).GetTypes());
            types.AddRange(Assembly.GetAssembly(typeof(FileEditorForm)).GetTypes());
            foreach (Type type in types)
            {
                if (type.IsSubclassOf(typeof(Form)) || type.IsSubclassOf(typeof(UserControl)))
                {
                    if (Properties.Settings.Default.ExcludeNamespace.Contains(type.Namespace))
                    {
                        continue;
                    }

                    ListViewGroup group = null;
                    ListViewItem item = new ListViewItem(new string[] { type.Name, "", type.Namespace });
                    item.Tag = type;

                    if (type.FullName == Properties.Settings.Default.RecentTestCase)
                    {
                        item.Selected = true;
                    }

                    foreach (ListViewGroup groupItem in testcasesListView.Groups)
                    {
                        if (groupItem.Header == type.Namespace)
                        {
                            group = groupItem;
                            break;
                        }
                    }
                    if (group == null)
                    {
                        group = new ListViewGroup(type.Namespace);
                        testcasesListView.Groups.Add(group);
                    }

                    item.Group = group;
                    testcasesListView.Items.Add(item);
                }
            }

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in testcasesListView.SelectedItems)
            {
                Type testCaseType = item.Tag as Type;
                object testCase = testCaseType.GetConstructor(Type.EmptyTypes).Invoke(null);
                if (testCase != null)
                {
                    try
                    {
                        if (testCase is ViewControl)
                        {
                            ViewControl control = testCase as ViewControl;
                            control.LoadData();
                            Form form = new Form();
                            form.Size = new Size(800, 600);
                            control.Dock = DockStyle.Fill;
                            form.Controls.Add(control);
                            form.Show();
                        }
                        else if (testCase is Form)
                        {
                            Form form = testCase as Form;
                            form.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        traceTextBox.Text = traceTextBox.Text + printException(ex);
                    }
                }
            }
        }

        private string printException(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            if (ex.InnerException != null)
            {
                sb.Append(printException(ex.InnerException));
            }
            sb.Append(ex.Message);
            sb.AppendLine();
            sb.Append(ex.StackTrace);
            sb.AppendLine();
            sb.AppendLine();
            return sb.ToString();
        }

        private void FormTestRuner_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (TestData.Instace().Server != null)
            {
                TestData.Instace().Server.Shutdown();
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void connect()
        {
            if (connectButton.Text == "&connect")
            {
                if (mocServerRadioButton.Checked)
                {
                    TestData.Instace().Server = new AsteriskServerMock();
                }
                else
                {
                    TestData.Instace().Server = new DefaultAsteriskServer("192.168.88.129", "admin", "abc123");
                }
                TestData.Instace().Initialize();
                connectButton.Text = "&disconnect";

                foreach (AsteriskController item in AsteriskManager.Default.AsteriskControllers)
                {
                    item.Server = TestData.Instace().Server;
                }
                AsteriskManager.Default.CurrentAsteriskController = AsteriskManager.Default.AsteriskControllers[0];
            }
            else
            {
                TestData.Instace().Dispose();
                connectButton.Text = "&connect";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            traceTextBox.Text = string.Empty;
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            loadTestAssembly();
        }

        private void autoConneectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoConnect = autoConneectCheckBox.Checked;
        }

        private void testcasesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (testcasesListView.SelectedItems.Count <= 0)
            {
                return;
            }
            Type type = testcasesListView.SelectedItems[0].Tag as Type;
            Properties.Settings.Default.RecentTestCase = type.FullName;
        }

        private void FormTestRuner_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}

