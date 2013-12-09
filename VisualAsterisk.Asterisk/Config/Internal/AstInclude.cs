using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Internal
{
    /// <summary>
    /// ast_include: include= support in extensions.conf 
    /// </summary>
    public class AstInclude
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string rname;			/*!< Context to include */

        public string Rname
        {
            get { return rname; }
            set { rname = value; }
        }
	    //string registrar;			/*!< Registrar */
	    //int hastime;				/*!< If time construct exists */
	    //struct ast_timing timing;               /*!< time construct */

        public override string ToString()
        {
            if (name != null && name.Length > 0)
            {
                return string.Format("include => {0}\n", name);
            }
            else
                return "";
        }
    }
}
