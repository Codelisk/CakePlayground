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
        public static string CSRPOJ_PATH = Path.Combine(GeneralConstants.RootPath, $"{GeneralConstants.AppName}.iOS/{GeneralConstants.AppName}.iOS.csproj");
    }
}
