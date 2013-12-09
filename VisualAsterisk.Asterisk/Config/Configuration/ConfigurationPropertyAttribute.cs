using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ConfigurationPropertyAttribute : System.Attribute
    {
        private string name;
        private bool exclude;
        private ConfigurationPropertyType propertyType;

        /// <summary>
        /// Exclude is true means this is not a ConfigurationProperty, should be exclude
        /// </summary>
        public bool Exclude
        {
            get { return exclude; }
        }

        /// <summary>
        /// Which kind of property
        /// </summary>
        internal ConfigurationPropertyType PropertyType
        {
            get { return propertyType; }
        }

        /// <summary>
        /// The Variable Name in config file
        /// </summary>
        public string Name
        {
            get { return name; }
        }

        public ConfigurationPropertyAttribute(ConfigurationPropertyType propertyType, string name)
            : this(propertyType)
        {
            this.name = name;
        }
        public ConfigurationPropertyAttribute(ConfigurationPropertyType propertyType)
            : this(false)
        {
            this.propertyType = propertyType;
        }

        public ConfigurationPropertyAttribute(bool exclude)
        {
            this.exclude = exclude;
        }
    }

    public enum ConfigurationPropertyType
    {
        Var, Object, Category, CategoryCollection
    }
}
