
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build.Constants
{
    public static class GeneralConstants
    {
        private const string GOBACK = "..";
        public const string APPNAME = "Orderlyze";
        public static string ROOT_PATH = Path.Combine(GOBACK, GOBACK, GOBACK, "Orderlyze_Mobile");
        public static string ROOT_APP_PATH = Path.Combine(ROOT_PATH, "src", APPNAME);
        public static string SLN_PATH = Path.Combine(ROOT_PATH, $"{APPNAME}.sln");
        public static string NUGETCONFIG_PATH = Path.Combine(ROOT_PATH, "Nuget.config");

        public const string APP_PACKAGE_FOLDER_NAME = "AppPackages";
        public static string BinPath(string configuration)
        {
            return Path.Combine(ROOT_APP_PATH, "bin", configuration);
        }
    }
}
