using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BugTracker
{
    public static class Settings
    {
        public const string extension = "bt";
        public static string def = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Bug Tracker");
    }
}
    