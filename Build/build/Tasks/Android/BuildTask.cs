using Build.Constants;
using Build.Tasks.Base;
using Build.Tasks.General.AppCenter;
using Build.Tasks.General.Setup;
using Cake.Common.Tools.MSBuild;
using Cake.Core.IO;
using Cake.Core;
using Cake.Frosting;
using Cake.Xamarin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cake.Core.Diagnostics;
using Cake.Common.IO;

namespace Build.Tasks.Android
{
    [TaskName("Build")]
    [IsDependentOn(typeof(RestoreTask))]
    public sealed class BuildTask : BaseTask
    {
        public override void Run(BuildContext context)
        {
            bool sign = true;
            var result = context.BuildAndroidApk(AndroidConstants.CSRPOJ_PATH, sign, context.MsBuildConfiguration, configurator: msBuildSettings =>
            {
                msBuildSettings.WithProperty("AndroidKeyStore", "True")
                               .WithProperty("AndroidSigningKeyAlias", AndroidConstants.ANDROID_KEYSTORE_ALIAS)
                               .WithProperty("AndroidSigningKeyPass", AndroidConstants.ANDROID_KEYSTORE_PASSWORD)
                               .WithProperty("AndroidSigningKeyStore", AndroidConstants.PATH_TO_ANDROID_KEYSTORE_FILE)
                               .WithProperty("AndroidSigningStorePass", AndroidConstants.ANDROID_KEYSTORE_PASSWORD);
            });

            var result2=MoveAppPackageToPackagesFolder(context, result);
        }
        public string MoveAppPackageToPackagesFolder(ICakeContext context, FilePath appPackageFilePath)
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
