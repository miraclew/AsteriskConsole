using System;
using System.Collections.Generic;
namespace VisualAsterisk.Asterisk.Config
{
    public interface IConfigFile
    {
        Dictionary<string, List<string>> Categories { get; }
        IList<Category> CategoryItems { get; }
        string FileName { get; }
        string GetValue(string categoryName, string key);
        List<string> GetValues(string categoryName, string key);
    }
}
