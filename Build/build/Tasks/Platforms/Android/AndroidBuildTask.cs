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

namespace Build.Tasks.Platforms.Android
{
    [TaskName("Build")]
    [IsDependentOn(typeof(RestoreTask))]
    public sealed class AndroidBuildTask : BaseTask
    {
        public override void Run(BuildContext context)
        {
            bool sign = true;
            var result = context.BuildAndroidApk(AndroidConstants.CSRPOJ_PATH, sign, context.MsBuildConfiguration);

            var result2=context.MoveAppPackageToPackagesFolder(result);
        }
    }
}
