using Build.Constants;
using Cake.Core.IO;
using Cake.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cake.Core.Diagnostics;
using Cake.Common.IO;

namespace Build.Tasks.Platforms
{
    public static class PlatformExtensions
    {
        public static string MoveAppPackageToPackagesFolder(this ICakeContext context, FilePath appPackageFilePath)
        {
            var packageFileName = appPackageFilePath.GetFilename();
            context.Log.Information("PackageFileName: " + packageFileName.FullPath);
            var targetAppPackageFilePath = new FilePath($"{GeneralConstants.APP_PACKAGE_FOLDER_NAME}/" + packageFileName);
            context.Log.Information("TargetAppPackageFilePath: " + targetAppPackageFilePath.FullPath);

            if (context.FileExists(targetAppPackageFilePath))
            {
                context.DeleteFile(targetAppPackageFilePath);
            }

            context.EnsureDirectoryExists($"{GeneralConstants.APP_PACKAGE_FOLDER_NAME}");
            context.MoveFile(appPackageFilePath, targetAppPackageFilePath);

            return targetAppPackageFilePath.ToString();
        }
    }
}
