using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config
{
    public class Category : ConfigElement
    {
        private string name;

        /// <summary>
        /// Returns the Name of this Category.
        /// </summary>
        public string Name
        {
            get { return name; }
        }
        private bool template;

        private readonly List<Category> baseCategories = new List<Category>();
        private readonly List<ConfigElement> elements = new List<ConfigElement>();

        /**
         * The Last object in the list will get assigned any trailing comments when EOF is hit.
         */
        //private string trailingComment;

        public Category(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Name must not be null");
            }
            this.name = name;
        }

        public Category(string filename, int lineno, string name)
            : base(filename, lineno)
        {
            this.name = name;
        }

        /**
         * Checks if this Category is a Template.
         *
         * @return <code>true</code> if this Category is a Template, <code>false</code> otherwise.
         */
        public bool isTemplate()
        {
            return template;
        }

        public void markAsTemplate()
        {
            template = true;
        }

        /**
         * Returns a list of Categories this Category inherits from.
         *
         * @return a list of Categories this Category inherits from, never <code>null</code>.
         */
        public List<Category> getBaseCategories()
        {
            return baseCategories;
        }

        internal void addBaseCategory(Category baseCategory)
        {
            baseCategories.Add(baseCategory);
        }

        public List<ConfigElement> Elements
        {
            get
            { return elements; }
        }

        public void addElement(ConfigElement element)
        {
            if (element is Category)
            {
                throw new ArgumentException("Nested categories are not allowed");
            }

            elements.Add(element);
        }

        public string format()
        {
            StringBuilder sb = new StringBuilder();

            format(sb);
            foreach (ConfigElement e in elements)
            {
                sb.Append("\n");
                e.format(sb);
            }
            return sb.ToString();
        }

        protected override StringBuilder rawFormat(StringBuilder sb)
        {
            sb.Append("[").Append(name).Append("]");
            if (isTemplate() || getBaseCategories().Count > 0)
            {
                sb.Append("(");
                if (isTemplate())
                {
                    sb.Append("!");
                    if (getBaseCategories().Count > 0)
                    {
                        sb.Append(",");
                    }
                }

                for (int i = 0; i < getBaseCategories().Count; i++)
                {
                    sb.Append(getBaseCategories()[i].Name);
                    if (i < getBaseCategories().Count - 1)
                    {
                        sb.Append(",");
                    }
                }
                sb.Append(")");
            }

            return sb;
        }

        public override string ToString()
        {
            return name;
        }

    }
}
