
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
        public const string AppName = "App1";
        public static string RootPath = $"../{AppName}";
        public static string SlnPath = System.IO.Path.Combine(RootPath, $"{AppName}.sln");

        public const string APP_PACKAGE_FOLDER_NAME = "AppPackages";
        public static string BinPath(string configuration)
        {
            return Path.Combine(RootPath, "bin", configuration);
        }
    }
}
