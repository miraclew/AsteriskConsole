using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;
using Asterisk.NET.Manager;
using Asterisk.NET.Manager.Event;
using  VisualAsterisk.Main.Controller;
using VisualAsterisk.Asterisk;

namespace VisualAsterisk.Main.Gui.SystemPanel
{
    //public delegate void FormEventsHandler(object sender, ManagerBaseFormEvent e);
    public class ManagerBaseForm : Form
    {
        public ManagerBaseForm()
        {
        }

        protected virtual void FormAsyncOperation(object data) { }
        /*
        private void managerEvent(object sender, ManagerEvent e) {
            try
            {
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                //throw;
            }
        }
        protected virtual void OnManagerEvent(object sender, ManagerEvent e) { }

        protected void SendFormEvent(object sender, ManagerBaseFormEvent e)
        {
            if (FormEvents != null)
            {
                FormEvents(sender, e);
            }
        }

        public event FormEventsHandler FormEvents;
*/
        private AsteriskController astController;

        public virtual AsteriskController AstController
        {
            get { return astController; }
            set
            {
                astController = value;
            }
        }


    }

    delegate void FormAsyncOperationDelegate(object data);    

/*    public class ManagerBaseFormEvent : EventArgs
    {
        public ManagerBaseFormEvent(string cmd)
        {
            this.command = cmd;
        }
        private string command;

        public string Command
        {
            get { return command; }
            set { command = Value; }
        }		
    }
 */
}
