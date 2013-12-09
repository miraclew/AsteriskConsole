using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace VisualAsterisk.Asterisk
{
    public class Backup
    {
        public static Backup CreateNew(string name)
        {
            Backup backup = new Backup();
            backup.name = name;
            backup.takenTime = DateTime.Now;
            backup.fileName = name + "__" + backup.takenTime.ToString("yyyyMMMdd", CultureInfo.CreateSpecificCulture("en-US")) + ".tar";
            return backup;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string fileName;
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        private DateTime takenTime;

        public DateTime TakenTime
        {
            get { return takenTime; }
            set { takenTime = value; }
        }
    }
}
