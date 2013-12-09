using System;
using System.Collections.Generic;
using System.Text;
using VisualAsterisk.Asterisk.Config;
using ICSharpCode.TextEditor.Gui.CompletionWindow;

namespace AstFileEditor
{
    class AsteriskConfigResolver
    {
        private Category currentCategory;
        private ConfigElement currentConfigElement;
        private List<ICompletionData> completionData = new List<ICompletionData>();

        public List<ICompletionData> Resolve(ConfigFile configFile, int lineNo, int columnNo)
        {
            completionData.Clear();
            for (int i = 0; i < configFile.CategoryItems.Count; i++)
            {
                Category cat = configFile.CategoryItems[i];
                int catLineNo = cat.LineNumber;
                if (lineNo < catLineNo)
                {
                    // not in a category
                    currentCategory = null;
                    currentConfigElement = null;
                    break;
                }
                else if (lineNo == catLineNo)
                {
                    currentCategory = cat;
                    break;
                }
                else
                {
                    if (i + 1 < configFile.CategoryItems.Count && lineNo >= configFile.CategoryItems[i + 1].LineNumber)
                    {
                        continue;
                    }
                    else
                    {
                        currentCategory = cat;
                        break;
                    }
                }
            }

            foreach (var item in ConfigFileVariablesDataBase.Default.FileVariables[configFile.FileName])
            {
                completionData.Add(new DefaultCompletionData(item,"",1));
            }

            return completionData;
        }
    }
}
