using System;
using System.Collections.Generic;
using System.Text;

namespace VisualAsterisk.Asterisk
{
    /// <summary>
    /// Represents the Version of an Asterisk server.
    /// </summary>
    public class AsteriskVersion : IComparable<AsteriskVersion>
    {
        private readonly int version;
        private readonly string versionString;

        /**
         * Represents the Asterisk 1.0 series.
         */
        public readonly AsteriskVersion ASTERISK_1_0 = new AsteriskVersion(100, "Asterisk 1.0");

        /**
         * Represents the Asterisk 1.2 series.
         */
        public readonly AsteriskVersion ASTERISK_1_2 = new AsteriskVersion(120, "Asterisk 1.2");

        /**
         * Represents the Asterisk 1.4 series.
         *
         * @since 0.3
         */
        public readonly AsteriskVersion ASTERISK_1_4 = new AsteriskVersion(140, "Asterisk 1.4");

        /**
         * Represents the Asterisk 1.6 series.
         *
         * @since 1.0.0
         */
        public readonly AsteriskVersion ASTERISK_1_6 = new AsteriskVersion(160, "Asterisk 1.6");

        private AsteriskVersion(int version, string versionString)
        {
            this.version = version;
            this.versionString = versionString;
        }

        /**
         * Returns <code>true</code> if this Version is equal to or higher than
         * the given Version.
         *
         * @param o the Version to compare to
         * @return <code>true</code> if this Version is equal to or higher than
         *         the given Version, <code>false</code> otherwise.
         */
        public bool isAtLeast(AsteriskVersion o)
        {
            return version >= o.version;
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            AsteriskVersion that = (AsteriskVersion)obj;

            return version == that.version;
        }

        public override int GetHashCode()
        {
            return version;
        }

        public override string ToString()
        {
            return versionString;
        }

        #region IComparable<AsteriskVersion> 成员

        public int CompareTo(AsteriskVersion other)
        {
            int otherVersion;

            otherVersion = other.version;
            if (version < otherVersion)
            {
                return -1;
            }
            else if (version > otherVersion)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        #endregion
    }
}
