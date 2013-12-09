
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;

using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Gui;
using ICSharpCode.TextEditor.Gui.CompletionWindow;
using ICSharpCode.TextEditor.Gui.InsightWindow;
using System.Diagnostics;

namespace AstFileEditor
{
    class CodeCompletionKeyHandler
    {
        FileEditorForm mainForm;
        TextEditorControl editor;
        CodeCompletionWindow codeCompletionWindow;

        private CodeCompletionKeyHandler(FileEditorForm mainForm, TextEditorControl editor)
        {
            this.mainForm = mainForm;
            this.editor = editor;
        }

        public static CodeCompletionKeyHandler Attach(FileEditorForm mainForm, TextEditorControl editor)
        {
            CodeCompletionKeyHandler h = new CodeCompletionKeyHandler(mainForm, editor);

            mainForm.KeyDown += new System.Windows.Forms.KeyEventHandler(h.mainForm_KeyDown);
            editor.ActiveTextAreaControl.TextArea.KeyEventHandler += h.TextAreaKeyEventHandler;
            // When the editor is disposed, close the code completion window
            editor.Disposed += h.CloseCodeCompletionWindow;

            return h;
        }

        private bool autoResetShortcutKeyPressed = false;
        private bool ShortcutKeyPressed
        {
            get
            {
                bool v = autoResetShortcutKeyPressed;
                autoResetShortcutKeyPressed = false;
                return v;
            }
            set { autoResetShortcutKeyPressed = value; }
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.O)
            {
                //showCompletionWindow((char)e.KeyCode);
                ShortcutKeyPressed = true;
                editor.BeginUpdate();
                editor.ActiveTextAreaControl.TextArea.SimulateKeyPress('.');
                e.Handled = true;
                editor.EndUpdate();
            }
        }

        /// <summary>
        /// Return true to handle the keypress, return false to let the text area handle the keypress
        /// </summary>
        bool TextAreaKeyEventHandler(char key)
        {
            if (codeCompletionWindow != null)
            {
                // If completion window is open and wants to handle the key, don't let the text area
                // handle it
                if (codeCompletionWindow.ProcessKeyEvent(key))
                    return true;
            }
            if (key == '.')
            {
                showCompletionWindow(key);
                if (ShortcutKeyPressed)
                {
                    return true;
                }
            }
            else if (key == '(')
            {
                //IInsightDataProvider insightDataProvider = new MethodInsightDataProvider(mainForm);

                //InsightWindow insightWindow = new InsightWindow(mainForm, editor);
                //insightWindow.AddInsightDataProvider(insightDataProvider, FileEditorForm.DummyFileName);
                //insightWindow.ShowInsightWindow();
            }

            return false;
        }

        private void showCompletionWindow(char key)
        {
            ICompletionDataProvider completionDataProvider = new CodeCompletionProvider(mainForm);

            codeCompletionWindow = CodeCompletionWindow.ShowCompletionWindow(
                mainForm,					// The parent window for the completion window
                editor, 					// The text editor to show the window for
                FileEditorForm.CurrentEditFileName,		// Filename - will be passed back to the provider
                completionDataProvider,		// Provider to get the list of possible completions
                key							// Key pressed - will be passed to the provider
            );
            if (codeCompletionWindow != null)
            {
                // ShowCompletionWindow can return null when the provider returns an empty list
                codeCompletionWindow.Closed += new EventHandler(CloseCodeCompletionWindow);
            }
        }
        void CloseCodeCompletionWindow(object sender, EventArgs e)
        {
            if (codeCompletionWindow != null)
            {
                codeCompletionWindow.Closed -= new EventHandler(CloseCodeCompletionWindow);
                codeCompletionWindow.Dispose();
                codeCompletionWindow = null;
            }
        }
    }
}
