using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;
using VisualAsterisk.Asterisk;
using System.Reflection;

namespace VisualAsterisk.Main.Controller
{
    public class CurrentAsteriskControllerChangedEventArg : System.EventArgs
    {
    }

    public enum AsteriskControllerItemChange
    {
        State
    }

    public class CurrentAsteriskControllerItemChangedEventArg : System.EventArgs
    {
        private AsteriskControllerItemChange change;

        public AsteriskControllerItemChange Change
        {
            get { return change; }
            set { change = value; }
        }
    }

    public class AsteriskManager
    {
        public event EventHandler<CurrentAsteriskControllerChangedEventArg> CurrentAsteriskControllerChanged;
        public event EventHandler<CurrentAsteriskControllerItemChangedEventArg> CurrentAsteriskControllerItemChanged;

        private static AsteriskManager instance;
        private string asteriskControllersXmlFileFullName;

        public string AsteriskControllersXmlFileFullName
        {
            get { return asteriskControllersXmlFileFullName; }
            set { asteriskControllersXmlFileFullName = value; }
        }
        
        static AsteriskManager()
        {
            instance = new AsteriskManager();
        }

        private AsteriskManager()
        {
        }

        public static AsteriskManager Default
        {
            get { return instance; }
        }

        private AsteriskController currentAsteriskController = null;
        private List<AsteriskController> asteriskControllers = null;


        public AsteriskController CurrentAsteriskController
        {
            get { return currentAsteriskController; }
            set
            {
                currentAsteriskController = value;
                EventHandler<CurrentAsteriskControllerChangedEventArg> eh = CurrentAsteriskControllerChanged;
                if (eh != null)
                {
                    eh(this, new CurrentAsteriskControllerChangedEventArg());
                }
                currentAsteriskController.Server.StateChanged += new EventHandler<ServerStateEventArg>(Server_StateChanged);
            }
        }

        void Server_StateChanged(object sender, ServerStateEventArg e)
        {
            EventHandler<CurrentAsteriskControllerItemChangedEventArg> eh = CurrentAsteriskControllerItemChanged;
            if (eh != null)
            {
                CurrentAsteriskControllerItemChangedEventArg arg = new CurrentAsteriskControllerItemChangedEventArg();
                arg.Change = AsteriskControllerItemChange.State;
                eh(this, arg);
            }
        }

        public List<AsteriskController> AsteriskControllers
        {
            get { return asteriskControllers; }
            set { asteriskControllers = value; }
        }

        public void Initial()
        {
            LoadControllers();
        }

        public void Shutdown()
        {
            SaveControllers();
        }

        private List<AsteriskController> readControllers(string file)
        {
            List<AsteriskController> controllers = null;
            try
            {
                FileStream fs = new FileStream(file, FileMode.Open);
                XmlSerializer xs = new XmlSerializer(typeof(List<AsteriskController>));
                controllers = xs.Deserialize(fs) as List<AsteriskController>;
                fs.Close();
            }
            catch (FileNotFoundException e)
            {
                Trace.TraceWarning("File not found: {0}", e.Message);
            }
            catch (IOException)
            {
                throw;
            }
            catch (InvalidOperationException e)
            {
                Trace.TraceError("Xml read error: {0}", e.Message);
            }
            return controllers;
        }
        
        private void writeControllersControllers(List<AsteriskController> controllers, string file)
        {
            try
            {
                FileStream fs = new FileStream(file, FileMode.Create);
                XmlSerializer xs = new XmlSerializer(typeof(List<AsteriskController>));
                xs.Serialize(fs, controllers);
                fs.Close();
            }
            catch (IOException)
            {
                throw;
            }
        }

        public void LoadControllers()
        {
            asteriskControllers = readControllers(asteriskControllersXmlFileFullName);
            if (asteriskControllers == null)
            {
                asteriskControllers = new List<AsteriskController>();
            }
        }

        private void SaveControllers()
        {
            writeControllersControllers(asteriskControllers, asteriskControllersXmlFileFullName);
        }

        public void ImportControllers(string file)
        {
            List<AsteriskController> controllers = readControllers(file);
            if (controllers != null)
            {
                asteriskControllers.AddRange(controllers);
                SaveControllers();
            }
        }

        public void ExportControllers(string file)
        {
            SaveControllers();
            File.Copy(asteriskControllersXmlFileFullName, file);
        }

        public bool IsCurrentControllerOK()
        {
            return currentAsteriskController != null && currentAsteriskController.Server != null && currentAsteriskController.Server.IsConnected();
        }

        private void reConnectServerIfNeeded()
        {
            if (currentAsteriskController != null && currentAsteriskController.Server != null && !currentAsteriskController.Server.IsConnected())
            {
                if ( currentAsteriskController.Server.State == ServerState.Initilized)
                {
                    currentAsteriskController.Server.Shutdown();
                    currentAsteriskController.Server.Initialize();
                }
            }
        }


    }
}
