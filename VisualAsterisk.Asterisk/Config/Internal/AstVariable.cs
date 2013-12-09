namespace VisualAsterisk.Asterisk.Config.Internal
{
    public class AstVariable
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string value;

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        int lineno;

        public int Lineno
        {
            get { return lineno; }
            set { lineno = value; }
        }
        int isObject; /*!< 0 for Variable, 1 for object */

        public int IsObject
        {
            get { return isObject; }
            set { isObject = value; }
        }
        int blanklines; 	/*!< Number of blanklines following entry */
        string precomments;
        string sameline;

        public override string ToString()
        {
            if (isObject == 1)
            {
                return string.Format("{0} => {1}\n", name, value);
            }
            else
                return string.Format("{0} = {1}\n", name, value);
            
        }
    }
}