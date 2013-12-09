using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config
{
    public class ConfigFile : VisualAsterisk.Asterisk.Config.IConfigFile
    {
        private readonly string fileName;
        protected readonly Dictionary<string, Category> categories;

        public string FileName
        {
            get { return fileName; }
        }

        public Dictionary<string, List<String>> Categories
        {
            get {
                Dictionary<string, List<string>> c;

                c = new Dictionary<string, List<string>>();

                lock (categories)
                {
                    foreach (Category category in categories.Values)
                    {
                        List<string> lines;

                        lines = new List<string>();
                        foreach (ConfigElement element in category.Elements)
                        {
                            if (element is ConfigVariable)
                            {
                                ConfigVariable cv = (ConfigVariable)element;
                                lines.Add(cv.Name + "=" + cv.Value);
                            }
                        }
                        c.Add(category.Name, lines);
                    }
                }

                return c;
            }
        } 

        public ConfigFile(string filename, Dictionary<string, Category> categories)
        {
            this.fileName = filename;
            this.categories = categories;
        }

        public string GetValue(string categoryName, string key)
        {
            Category category;

            category = getCategory(categoryName);
            if (category == null)
            {
                return null;
            }

            foreach (ConfigElement element in category.Elements)
            {
                if (element is ConfigVariable)
                {
                    ConfigVariable cv = (ConfigVariable)element;

                    if (cv.Name.Equals(key))
                    {
                        return cv.Value;
                    }
                }
            }
            return null;
        }

        public List<string> GetValues(string categoryName, string key)
        {
            Category category;
            List<string> result;

            category = getCategory(categoryName);
            result = new List<string>();
            if (category == null)
            {
                return result;
            }

            foreach (ConfigElement element in category.Elements)
            {
                if (element is ConfigVariable)
                {
                    ConfigVariable cv = (ConfigVariable)element;

                    if (cv.Name.Equals(key))
                    {
                        result.Add(cv.Value);
                    }
                }
            }
            return result;
        }

        protected Category getCategory(string name)
        {
            lock (categories)
            {
                return categories[name];
            }
        }


        #region IConfigFile 成员


        public IList<Category> CategoryItems
        {
            get
            {
                lock (categories)
                {
                    List<Category> categorieList = new List<Category>();
                    foreach (Category item in categories.Values)
                    {
                        categorieList.Add(item);
                    }
                    return categorieList;
                }
            }
        }

        #endregion
    }
}
