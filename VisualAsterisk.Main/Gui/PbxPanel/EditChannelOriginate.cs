using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VisualAsterisk.Asterisk;

namespace VisualAsterisk.Main.Gui.PbxPanel
{
    public partial class EditChannelOriginate : DialogBase
    {
        #region ToExten
        private string context;
        private string exten;
        private int priority;

        public string Context
        {
            get
            {
                context = this.textBoxContext.Text;
                return context;
            }
            set { context = value; }
        }

        public string Exten
        {
            get
            {
                exten = this.textBoxExten.Text;
                return exten;
            }
            set { exten = value; }
        }

        public int Priority
        {
            get
            {
                priority = int.Parse(textBoxPriority.Text);
                return priority;
            }
            set { priority = value; }
        }
        #endregion

        #region ToApplication
        private string application;
        private string data;

        public string Application
        {
            get
            {
                application = this.textBoxApplication.Text;
                return application;
            }
            set { application = value; }
        }

        public string Data
        {
            get
            {
                data = this.textBoxData.Text;
                return data;
            }
            set { data = value; }
        }
        #endregion

        #region Channel options and variables
        private string channel;
        private int timeout;
        private CallerId callerId;
        private BindingList<VariableBinding> variables;

        public string Channel
        {
            get
            {
                channel = channelTextBox.Text;
                return channel;
            }
            set
            {
                channel = value;
            }
        }

        public int Timeout
        {
            get
            {
                timeout = int.Parse(this.textBoxTimeout.Text);
                return timeout;
            }
            set { timeout = value; }
        }

        public CallerId CallerId
        {
            get
            {
                callerId = null;
                if (!string.IsNullOrEmpty(this.textBoxCallerIdName.Text) && !string.IsNullOrEmpty(this.textBoxCallerIdNumber.Text))
                {
                    callerId = new CallerId(this.textBoxCallerIdName.Text, this.textBoxCallerIdNumber.Text);
                }
                return callerId;
            }
            set { callerId = value; }
        }

        public BindingList<VariableBinding> Variables
        {
            get { return variables; }
            set
            {
                variables = value;
                this.variableBindingBindingSource.DataSource = variables;
            }
        }
        #endregion

        public EditChannelOriginate()
        {
            InitializeComponent();
            variables = new BindingList<VariableBinding>();
            this.variableBindingBindingSource.DataSource = variables;
        }
    }

    // TODO: this is a rubbish class
    public class VariableBinding
    {
        public VariableBinding()
        {

        }
        public VariableBinding(string variable, string _value)
        {
            this.variable = variable;
            this._value = _value;
        }

        private string variable;

        public string Variable
        {
            get { return variable; }
            set { variable = value; }
        }
        private string _value;

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
