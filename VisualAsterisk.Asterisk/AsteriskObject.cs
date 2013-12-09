using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace VisualAsterisk.Asterisk
{
    public abstract class AsteriskObject : INotifyPropertyChanged
    {
        protected object asteriskObjectLock = new object();
        protected DefaultAsteriskServer server;

        public AsteriskObject(DefaultAsteriskServer server)
        {
            this.server = server;
        }

        protected virtual void firePropertyChange(string propertyName, object oldValue, object newValue)
        {
            if (PropertyChanged == null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
