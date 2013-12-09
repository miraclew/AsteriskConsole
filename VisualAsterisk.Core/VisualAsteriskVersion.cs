using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Collections.Specialized;

namespace VisualAsterisk.Core
{
    [Serializable]
    public class VisualAsteriskVersion : IComparable<VisualAsteriskVersion>
    {
        private StringCollection features;
        private StringCollection bugfixes;
        private string version;

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        public StringCollection Features
        {
            get { return features; }
            set { features = value; }
        }

        public StringCollection Bugfixes
        {
            get { return bugfixes; }
            set { bugfixes = value; }
        }

        public VisualAsteriskVersion()
        {
        }

        public VisualAsteriskVersion(string version)
        {
            this.version = version;
        }

        public bool NewerThan(VisualAsteriskVersion other)
        {
            return this.CompareTo(other) > 0;
        }

        #region IComparable<VisualAsteriskVersion> 成员

        public int CompareTo(VisualAsteriskVersion other)
        {
            System.Version thisVersion = new Version(version);
            System.Version otherVersion = new Version(other.Version);
            return thisVersion.CompareTo(otherVersion);
        }

        #endregion
    }
}
