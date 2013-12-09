using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;
using System.IO;
using System.Xml;

namespace AstFileEditor
{
    public partial class FileEditorForm : Form
    {
        public static string CurrentEditFileName = "";
        public FileEditorForm()
        {
            InitializeComponent();

            //textEditorControl1.Text = Class1.manager_conf;
            //toolStripComboBox2.Items.AddRange(FileLoader.Default.AllConfigFiles.);

            string dir = "Resources"; // Insert the path to your xshd-files.
            FileSyntaxModeProvider fsmProvider; // Provider
            if (Directory.Exists(dir))
            {
                fsmProvider = new FileSyntaxModeProvider(dir); // Create new provider with the highlighting directory.
                HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmProvider); // Attach to the text editor.                
                textEditorControl1.SetHighlighting("AstConfig");
            }

            CodeCompletionKeyHandler.Attach(this, textEditorControl1);
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fileName = toolStripComboBox2.SelectedItem.ToString();
            CurrentEditFileName = fileName;
            if (fileName == "manager.conf")
            {
                textEditorControl1.Text = Class1.manager_conf;
            }
            else if (fileName == "extensions.conf")
            {
                textEditorControl1.Text = Class1.extensions_conf;
            }
            else if (fileName == "users.conf")
            {
                textEditorControl1.Text = Class1.users_conf;
            }
            //if (FileLoader.Default.Load(fileName))
            //{
            //    textEditorControl1.LoadFile(fileName);
            //}
        }

        private void 保存SToolStripButton1_Click(object sender, EventArgs e)
        {
            textEditorControl1.SaveFile(textEditorControl1.FileName);
            FileLoader.Default.Save(textEditorControl1.FileName);
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
