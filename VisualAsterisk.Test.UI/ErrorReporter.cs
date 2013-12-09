using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VisualAsterisk.Test.UI
{
    public partial class ErrorReporter : Form
    {
        private string errorMessage;

        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                errorMessage = value;
                this.textBox1.Text = errorMessage;
            }
        }

        public ErrorReporter()
        {
            InitializeComponent();
            this.textBox1.Text = errorMessage;
        }
    }
}
