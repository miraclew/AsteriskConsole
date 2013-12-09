using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk.Config.Internal
{
    /// <summary>
    /// ast_exten: An Extension1
    /// The dialplan is saved as a linked list with each Context
    /// having it's own linked list of extensions - one item per
    /// Priority.
    /// </summary>
    public class AstExten
    {
        public AstExten(string context, string extension, int priority)
            : this(context, extension, priority, null, null)
        {
        }

        public AstExten(string context, string extension,
                     int priority, string application, object appData)
            : this(context, extension, priority, application, appData, null)
        {
        }

        public AstExten(string context, string extension,
                     int priority, string application, object appData, string label)
        {
            this.context = context;
            this.exten = extension;
            this.priority = priority;
            this.application = application;
            this.appData = appData;
            this.label = label;
        }

        string context;

        public string Context
        {
            get { return context; }
            set { context = value; }
        }

        string exten;			/*!< Extension Name */

        public string Exten
        {
            get { return exten; }
            set { exten = value; }
        }
        //int matchcid;			/*!< Match caller Id ? */
        //string cidmatch;		/*!< Caller Id to Match for this Extension1 */
        int priority;			/*!< Priority */

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        string label;		/*!< Label */

        public string Label
        {
            get { return label; }
            set { label = value; }
        }
        //AstContext parent;	/*!< The Context this Extension1 belongs to  */
        string application; 		/*!< Application to execute */

        public string Application
        {
            get { return application; }
            set { application = value; }
        }
        object appData;			/*!< Data to use (Arguments1) */

        public object AppData
        {
            get { return appData; }
            set { appData = value; }
        }
        //AstExten Peer;		/*!< Next higher Priority with our Extension1 */
        //string registrar;		/*!< Registrar */

        public override string ToString()
        {
            string lbl = "";
            if (label != null && label.Length > 0)
            {
                lbl = string.Format("({0})", label);
            }
            return string.Format("exten => {0},{1}{2},{3}({4})\n", exten, priority, lbl, application, appData);
        }
    }
}
