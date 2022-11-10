using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build.Constants
{
    public static class IosConstants
    {
        public static string CSRPOJ_PATH = Path.Combine(GeneralConstants.ROOT_APP_PATH, $"{GeneralConstants.APPNAME}.iOS",$"{GeneralConstants.APPNAME}.iOS.csproj");
    }
}
