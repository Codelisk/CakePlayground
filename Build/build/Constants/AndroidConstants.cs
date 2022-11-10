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
        public static string CSRPOJ_PATH = Path.Combine(GeneralConstants.RootPath, $"{GeneralConstants.AppName}.Android", $"{GeneralConstants.AppName}.Android.csproj");

        public const string ANDROID_KEYSTORE_ALIAS = "Legacyorder";
        public const string ANDROID_KEYSTORE_PASSWORD = "Huda$$18";
        public const string PATH_TO_ANDROID_KEYSTORE_FILE = "C:\\Users\\Daniel\\Desktop\\Projects\\Orderlyze\\Cake\\CakePlayground\\Build\\App1\\App1.Android\\LegacyOrder.keystore";
    }
}
