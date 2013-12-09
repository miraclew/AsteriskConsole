using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config
{
    [AttributeUsage(AttributeTargets.Property|AttributeTargets.Field)]
    class AstConfigVariableAttribute : System.Attribute
    {
        public AstConfigVariableAttribute(bool isObject)
        {
            this.isObject = isObject;
        }

        bool isObject;

        public bool IsObject
        {
            get { return isObject; }
            set { isObject = value; }
        }

    }
}
