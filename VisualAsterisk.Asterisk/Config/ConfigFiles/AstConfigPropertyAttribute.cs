using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config
{
    [AttributeUsage(AttributeTargets.Property)]
    class AstConfigPropertyAttribute : System.Attribute
    {
        public AstConfigPropertyAttribute(AstConfigPropertyClass propertyClass, string name) : this(propertyClass)
        {
            this.name = name;
        }
        public AstConfigPropertyAttribute(AstConfigPropertyClass propertyClass) : this(false)
        {
            this.propertyClass = propertyClass;
        }

        public AstConfigPropertyAttribute(bool exclude)
        {
            this.exclude = exclude;
        }

        bool exclude;

        public bool Exclude
        {
            get { return exclude; }
            set { exclude = value; }
        }

        AstConfigPropertyClass propertyClass;

        internal AstConfigPropertyClass PropertyClass
        {
            get { return propertyClass; }
            set { propertyClass = value; }
        }

        Type type;

        public Type Type
        {
            get { return type; }
            set { type = value; }
        }

        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    enum AstConfigPropertyClass
    {
        Var, Object, Category, CategoryCollection
    }


}
