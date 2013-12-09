using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace VisualAsterisk.Asterisk.Config.Configuration
{
    public class ConfigurationItemBase : AsteriskObject, IEditableObject
    {
        public ConfigurationItemBase()
            : base(null)
        {
        }

        public ConfigurationItemBase(ConfigurationItemBase obj)
            : this()
        {
            copy(obj);
        }

        #region IEditableObject 成员
        private bool addingNew = false;
        protected bool editing = false;
        protected Dictionary<string, ConfigurationChange> changes = new Dictionary<string, ConfigurationChange>();
        protected ConfigurationItemBase savedObject;

        /// <summary>
        /// true means this item is adding from UI, not commit to server yet
        /// </summary>
        public bool AddingNew
        {
            get { return addingNew; }
            set { addingNew = value; }
        }

        /// <summary>
        /// Map of pending ConfigurationChange by id
        /// </summary>
        public Dictionary<string, ConfigurationChange> Changes
        {
            get { return changes; }
        }

        /// <summary>
        /// Call this metod when changes have been committed
        /// </summary>
        public void PendingChangesCommitted()
        {
            changes.Clear();
        }

        /// <summary>
        /// Map ConfigurationChanges by file Name
        /// key is the file Name, value is the list of ConfigurationChange in the file
        /// </summary>
        public Dictionary<string, List<ConfigurationChange>> FileChanges
        {
            get
            {
                Dictionary<string, List<ConfigurationChange>> fileChanges = new Dictionary<string, List<ConfigurationChange>>();
                foreach (ConfigurationChange c in changes.Values)
                {
                    if (!fileChanges.ContainsKey(c.Filename))
                    {
                        fileChanges[c.Filename] = new List<ConfigurationChange>();
                    }
                    fileChanges[c.Filename].Add(c);
                }
                return fileChanges;
            }
        }

        protected override void firePropertyChange(string propertyName, object oldValue, object newValue)
        {
            base.firePropertyChange(propertyName, oldValue, newValue);

            if (oldValue != null && newValue != null && oldValue.Equals(newValue))
            {
                return;
            }
            else
            {
                if (editing)
                {
                    string variable = ConfigurationUtil.GetConfigVariable(this.GetType().GetProperty(propertyName));
                    ConfigurationChange change = new ConfigurationChange();
                    change.Variable = variable;
                    change.Value = ConfigurationUtil.ToConfigValueString(newValue);
                    addChange(change);
                }
            }
        }

        protected void addChange(ConfigurationChange change)
        {
            if (!editing) return;
            removeDuplicateChangeIfHas(change);
            changes.Add(change.Id, change);
        }

        private bool removeDuplicateChangeIfHas(ConfigurationChange change)
        {
            foreach (ConfigurationChange c in changes.Values)
            {
                if (hasSameStringValue(c.Filename,change.Filename) &&
                    hasSameStringValue(c.Category, change.Category) &&
                    hasSameStringValue(c.Variable, change.Variable) && 
                    hasSameStringValue(c.Match, change.Match))
                {
                    changes.Remove(c.Id);
                    return true;
                }
            }
            return false;
        }

        private bool hasSameStringValue(string first, string second)
        {
            if (string.IsNullOrEmpty(first) && string.IsNullOrEmpty(second))
                return true;
            else if (!string.IsNullOrEmpty(first) && !string.IsNullOrEmpty(second) && first.Equals(second))
                return true;
            else
                return false;
        }

        /// <summary>
        /// clone the values from other object
        /// </summary>
        /// <param Name="obj"></param>
        protected virtual void copy(ConfigurationItemBase obj) { }

        /// <summary>
        /// Create new copy of this instance
        /// </summary>
        /// <returns></returns>
        public virtual ConfigurationItemBase Copy() { return null; }

        public virtual void BeginEdit()
        {
            if (editing) return;
            savedObject = this.Copy();
            editing = true;
        }

        public virtual void CancelEdit()
        {
            if (!editing) return;

            editing = false;
            changes.Clear();
            copy(savedObject);
            savedObject = null;
        }

        public virtual void EndEdit()
        {
            if (editing)
            {
                editing = false;
            }
        }

        #endregion
    }
}
