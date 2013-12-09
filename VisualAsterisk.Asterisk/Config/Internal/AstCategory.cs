using System.Collections;
using System.Collections.Generic;

namespace VisualAsterisk.Asterisk.Config.Internal
{
    public class AstCategory
    {
        public AstCategory()
        {
            variables = new List<AstVariable>();
        }
        private string name;
    	int ignored;			/*!< do not let User of the config see this Category */
	    int include_level;	
	    string precomments;
	    string sameline;
        private List<AstVariable> variables;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<AstVariable> Variables
        {
            get { return variables; }
            set { variables = value; }
        }
    }
}