using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build.Constants
{
    public static class AndroidConstants
    {
        public static string ANDROID_PROJECT_PATH = Path.Combine(GeneralConstants.ROOT_APP_PATH, $"{GeneralConstants.APPNAME}.Android");
        public static string CSRPOJ_PATH = Path.Combine(ANDROID_PROJECT_PATH, $"{GeneralConstants.APPNAME}.Android.csproj");
        public static string PATH_TO_ANDROID_KEYSTORE_FILE = "LegacyOrder.keystore";

        public const string ANDROID_KEYSTORE_ALIAS = "Legacyorder";
        public const string ANDROID_KEYSTORE_PASSWORD = "Huda$$18";
    }
}
