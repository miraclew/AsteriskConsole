using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace VisualAsterisk.Core.Util
{
    // TODO: this class is duplicate with IC.Utilities.AssemblyBuildDateHelper, should be removed
    public class Helper
    {
        public static DateTime GetExecutingAssemblyBuildDate()
        {
            Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            return GetAssemblyBuildDate(assembly);
        }

        public static DateTime GetAssemblyBuildDate(Assembly assembly)
        {
            Version version = assembly.GetName().Version;
            DateTime result = new DateTime(2000, 1, 1);
            result = result.AddDays(version.Build);
            result = result.AddSeconds(version.Revision * 2);
            if (TimeZone.IsDaylightSavingTime(DateTime.Now, TimeZone.CurrentTimeZone.GetDaylightChanges(DateTime.Now.Year)))
            {
                result = result.AddHours(1);
            }
            return result;
        }

        // alternative implment
        public static DateTime GetAssemblyBuildDate2(Assembly assembly)
        {
            return System.IO.File.GetLastWriteTime(assembly.Location);
        }
    }
}
