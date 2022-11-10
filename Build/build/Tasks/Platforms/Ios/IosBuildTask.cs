using Build.Constants;
using Build.Tasks.Base;
using Build.Tasks.General.Setup;
using Cake.Core.IO;
using Cake.Core;
using Cake.Frosting;
using Cake.Xamarin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cake.Common.Tools.MSBuild;
using Cake.Core.Diagnostics;

namespace Build.Tasks.Platforms.Ios
{
    [TaskName(nameof(IosBuildTask))]
    [IsDependentOn(typeof(RestoreTask))]
    public sealed class IosBuildTask : BaseTask
    {
        public override void Run(BuildContext context)
        {
            var ipaFilePath = context.BuildiOSIpa(IosConstants.CSRPOJ_PATH, context.MsBuildConfiguration);

            context.Log.Information("LOG----IOS IPA FILE: " + ipaFilePath?.FullPath);

            context.MoveAppPackageToPackagesFolder(ipaFilePath);
        }
    }
}
