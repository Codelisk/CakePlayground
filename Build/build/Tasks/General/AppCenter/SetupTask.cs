using Build.Constants;
using Build.Tasks.Base;
using Build.Tasks.General.Setup;
using Build.Tasks.Platforms.Android;
using Build.Tasks.Platforms.Ios;
using Cake.AppCenter;
using Cake.Common;
using Cake.Core.IO;
using Cake.Frosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build.Tasks.General.AppCenter
{
    [TaskName(nameof(SetupTask))]
    [IsDependentOn(typeof(AndroidBuildTask))]
    public sealed class SetupTask : BaseTask
    {
        public override void Run(BuildContext context)
        {
        }
    }
}
