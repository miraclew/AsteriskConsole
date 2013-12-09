using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace VisualAsterisk.Main.Gui.AutoCompletion
{
    interface ICompletionDataProvider
    {
        ImageList ImageList { get; }

        ICompletionData[] GenerateCompletionData();
    }
}
