using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

using VisualAsterisk;
using VisualAsterisk.Main.Gui.AutoCompletion;
using VisualAsterisk.Asterisk.Dialplan.Functions;
using VisualAsterisk.Asterisk.Dialplan.Application;
using VisualAsterisk.Asterisk;
using VisualAsterisk.Asterisk.Config;
using VisualAsterisk.Asterisk.Config.Internal;

namespace VisualAsterisk.Main.Gui.SystemPanel
{
    public partial class EditExtenForm : Form
    {
        public EditExtenForm(AstContext context)
        {
            InitializeComponent();
            m_AutoCompleteListBox = new ListBox();

            AutoCompleteStringCollection apps = new AutoCompleteStringCollection();
            foreach (string var in ApplicationBase.Applications.Keys)
            {
                apps.Add(var);
            }
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox2.AutoCompleteCustomSource = apps;

            this.m_Context = context;
        }

        // zero based
        private int getCurrentParameterIndex()
        {
            string txt = textBox2.Text;
            int pos = textBox2.SelectionStart;
            string trimedTxt = txt.Substring(0, pos);
            int count = trimedTxt.Split(',').Length;
            return count - 1;
        }

        private AstContext m_Context;

        private IConfig m_Config;

        public IConfig ConfigManager
        {
            get { return m_Config; }
            set { m_Config = value; }
        }

        private ListBox m_AutoCompleteListBox;

        private SimpleCompletionDataCollection FindCompletionData(ApplicationBase ab, int parameterIndex)
        {
            List<string> ac = ab.GetAutoCompleteDataById(parameterIndex);
            if (ac != null && ac.Count > 0)
            {
                SimpleCompletionDataCollection scdc = new SimpleCompletionDataCollection();
                foreach (string var in ac)
                {
                    SimpleCompletionData data = new SimpleCompletionData();
                    data.DisplayName = data.InsertName = var;
                    data.Category = CompletionDataCategory.Data;
                    scdc.CompletionDataCollection.Add(data);
                }
                return scdc;
            }
            else
                return null;
        }

        CompletionWindow m_CompletionWindow = null;
        string m_EnteredApplicationName = null;
        AstExten m_Exten = null;

        public AstExten Exten
        {
            set
            {
                m_Exten = value;
                this.textBoxExten.Text = m_Exten.Exten;
                this.numericUpDown1.Value = m_Exten.Priority;
                textBox2.Text = string.Format("{0}({1})", m_Exten.Application, m_Exten.AppData);
                textBoxLabel.Text = m_Exten.Label;
            }

            get
            {
                string exten = null, application = null, label = null;
                int priority;
                object appData = null;
                exten = this.textBoxExten.Text;
                priority = (int)this.numericUpDown1.Value;
                int idx1 = textBox2.Text.IndexOf('(');
                int idx2 = textBox2.Text.LastIndexOf(')');
                application = this.textBox2.Text.Substring(0, idx1);
                appData = textBox2.Text.Substring(idx1 + 1, idx2 - idx1 - 1);
                label = this.textBoxLabel.Text;
                m_Exten = new AstExten(m_Context.Name, exten, priority, application, appData, label);
                return m_Exten;
            }
        }
        List<AstExten> m_Extens;

        public List<AstExten> Extens
        {
            get { return m_Extens; }
            set
            {
                m_Extens = value;
                if (m_Extens != null && m_Extens.Count > 0)
                {

                    textBoxExten.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    textBoxExten.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
                    foreach (AstExten var in m_Extens)
                    {
                        if (var.Exten != null && var.Exten.Length > 0)
                        {
                            acsc.Add(string.Copy(var.Exten));
                        }
                    }
                    textBoxExten.AutoCompleteCustomSource = acsc;
                    AstExten last = m_Extens[m_Extens.Count - 2]; // since the datasource append a new instance, we need minus 2
                    this.numericUpDown1.Value = last.Priority + 1;
                    if (last.Exten != null)
                    {
                        this.textBoxExten.Text = last.Exten;
                    }
                }
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            Debug.WriteLine(string.Format("Cursor pos={0}", textBox2.SelectionStart));
            // ( pressed, create new Application
            if (e.KeyCode == Keys.D9 && e.Modifiers == Keys.Shift) // '('
            {
                m_EnteredApplicationName = textBox2.Text.Substring(0, textBox2.Text.IndexOf('('));
                if (ApplicationBase.Applications.Keys.Contains(m_EnteredApplicationName))
                {
                    Type t = ApplicationBase.Applications[m_EnteredApplicationName];
                    ApplicationBase ab = t.GetConstructor(Type.EmptyTypes).Invoke(null) as ApplicationBase;
                    ab.ConfigManager = m_Config;
                    textBox2.Tag = ab;
                    string[] parameters = new string[ab.AutoCompleteDataList.Length];
                    for (int i = 0; i < ab.AutoCompleteDataList.Length; i++)
                    {
                        parameters[i] = string.Format("{0}: {1}", i + 1, ab.AutoCompleteDataList[i]);
                    }

                    textBox1.Lines = parameters;
                }
                else
                {
                    m_EnteredApplicationName = null;
                }
            }

            // Pop up CompletionWindow for Application argument completion assist
            if ((e.KeyCode == Keys.D9 && e.Modifiers == Keys.Shift) || e.KeyCode == Keys.Oemcomma)
            {
                ApplicationBase ab = textBox2.Tag as ApplicationBase;
                if (ab != null)
                {
                    int parameterIndex = getCurrentParameterIndex();
                    SimpleCompletionDataCollection dc = FindCompletionData(ab, parameterIndex);
                    if (showCompletionWindow(dc) == DialogResult.OK)
                    {
                        ab.SetParameterValueByIndex(parameterIndex, m_CompletionWindow.MemberText);
                    }
                }
            }
            else if (e.KeyCode == Keys.D0 && e.Modifiers == Keys.Shift)
            {
                if (m_CompletionWindow != null)
                {
                    m_CompletionWindow.Close();
                }
            }

            // '$' pressed, Pop up CompletionWindow for Variable completion assist
            if (e.KeyCode == Keys.D4 && e.Modifiers == Keys.Shift)
            {
                // insert brace {}
                int newSelectionStart = textBox2.SelectionStart + 1;
                textBox2.Text = textBox2.Text.Insert(textBox2.SelectionStart, "{}"); // this will reset SelectionStart
                textBox2.SelectionStart = newSelectionStart;

                Extension exten = m_Config[ConfigFileEnum.Extensions] as Extension;
                SimpleCompletionDataCollection dc = new SimpleCompletionDataCollection();
                foreach (AstVariable var in exten.Globals)
                {
                    SimpleCompletionData data = new SimpleCompletionData();
                    data.DisplayName = data.InsertName = var.Name;
                    data.Category = CompletionDataCategory.Variable;
                    dc.CompletionDataCollection.Add(data);
                }
                showCompletionWindow(dc);
            }

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                Debug.WriteLine(string.Format("Cursor pos={0}", textBox2.SelectionStart));
            }
            e.Handled = true;
        }

        private string printConstructors(Type t)
        {
            // display avaliable ctors
            ConstructorInfo[] cis = t.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
            StringBuilder sb = new StringBuilder();
            foreach (ConstructorInfo ctor in cis)
            {
                sb.AppendFormat("{0}(", ctor.ReflectedType.Name);
                ParameterInfo[] pis = ctor.GetParameters();
                for (int i = 0; i < pis.Length; i++)
                {
                    sb.AppendFormat("{0}", pis[i].Name);
                    if (i < pis.Length - 1)
                    {
                        sb.Append(", ");
                    }
                }
                sb.Append(")\n");
            }
            return sb.ToString();
        }

        private DialogResult showCompletionWindow(SimpleCompletionDataCollection dc)
        {
            if (dc == null) return DialogResult.Abort;

            Point p = new Point(this.PointToScreen(this.textBox2.Location).X + textBox2.GetPositionFromCharIndex(textBox2.SelectionStart - 1).X,
                            this.PointToScreen(this.textBox2.Location).Y + textBox2.ClientSize.Height);
            m_CompletionWindow = new CompletionWindow(p, dc, null);
            DialogResult result = m_CompletionWindow.ShowDialog();
            if (result == DialogResult.OK)
            {
                int newSelectionStart = textBox2.SelectionStart + m_CompletionWindow.MemberText.Length;
                textBox2.Text = textBox2.Text.Insert(textBox2.SelectionStart, m_CompletionWindow.MemberText);
                textBox2.Select();
                textBox2.SelectionStart = newSelectionStart;
                textBox2.SelectionLength = 0;
            }
            return result;
        }

        private void insertFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimpleCompletionDataCollection dc = new SimpleCompletionDataCollection();
            foreach (string var in FunctionBase.Functions.Keys)
            {
                SimpleCompletionData data = new SimpleCompletionData();
                data.DisplayName = data.InsertName = var;
                data.Category = CompletionDataCategory.Function;
                dc.CompletionDataCollection.Add(data);
            }
            showCompletionWindow(dc);
        }

        private void insertApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimpleCompletionDataCollection dc = new SimpleCompletionDataCollection();
            foreach (string var in ApplicationBase.Applications.Keys)
            {
                SimpleCompletionData data = new SimpleCompletionData();
                data.DisplayName = data.InsertName = var;
                data.Category = CompletionDataCategory.Application;
                dc.CompletionDataCollection.Add(data);
            }
            showCompletionWindow(dc);
        }

        private void insertMacroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extension exten = m_Config[ConfigFileEnum.Extensions] as Extension;
            SimpleCompletionDataCollection dc = new SimpleCompletionDataCollection();
            foreach (AstMacro var in exten.Macros)
            {
                SimpleCompletionData data = new SimpleCompletionData();
                data.DisplayName = data.InsertName = var.Name;
                data.Category = CompletionDataCategory.Macro;
                dc.CompletionDataCollection.Add(data);
            }
            showCompletionWindow(dc);
        }

    }
}