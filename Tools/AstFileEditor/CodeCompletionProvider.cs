using System;
using System.Collections.Generic;
using System.Text;
using ICSharpCode.TextEditor.Gui.CompletionWindow;
using VisualAsterisk.Asterisk.Config;

namespace AstFileEditor
{
    class CodeCompletionProvider : ICompletionDataProvider
    {
        FileEditorForm mainForm;

        public CodeCompletionProvider(FileEditorForm mainForm)
        {
            this.mainForm = mainForm;
        }

        private ICompletionData[] GlobalCompleteData
        {
            get 
            {
                List<ICompletionData> data = new List<ICompletionData>();
                
                foreach (string item in Properties.Settings.Default.ExtenKeywords)
                {
                    data.Add(new DefaultCompletionData(item, "",12));
                }
                return data.ToArray();
            }
        }

        #region ICompletionDataProvider 成员

        public int DefaultIndex
        {
            get { return -1; }
        }

        public ICompletionData[] GenerateCompletionData(string fileName, ICSharpCode.TextEditor.TextArea textArea, char charTyped)
        {
            ConfigFile configFile = AsteriskConfigParser.Parse(fileName, textArea.Document.TextContent);
            AsteriskConfigResolver resolver = new AsteriskConfigResolver();
            List<ICompletionData> data = resolver.Resolve(configFile, textArea.Caret.Line, textArea.Caret.Column);

            return data.ToArray();
            //if (char.IsLetter(charTyped) || charTyped == '.')
            //{
            //    return GlobalCompleteData;
            //}
            //else
            //    return null;
        }

        private void parse()
        {
        }

        public System.Windows.Forms.ImageList ImageList
        {
            get { return mainForm.imageList1; }
        }

        public bool InsertAction(ICompletionData data, ICSharpCode.TextEditor.TextArea textArea, int insertionOffset, char key)
        {
            textArea.Caret.Position = textArea.Document.OffsetToPosition(insertionOffset);
            return data.InsertAction(textArea, key);
        }

        public string PreSelection
        {
            get
            {
                return "";
            }
        }

        public CompletionDataProviderKeyResult ProcessKey(char key)
        {
            if (char.IsLetterOrDigit(key) || key == '_')
            {
                return CompletionDataProviderKeyResult.NormalKey;
            }
            else
            {
                // key triggers insertion of selected items
                return CompletionDataProviderKeyResult.InsertionKey;
            }
        }

        #endregion
    }
}
