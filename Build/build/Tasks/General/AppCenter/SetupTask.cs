using Build.Constants;
using Build.Tasks.Android;
using Build.Tasks.Base;
using Build.Tasks.General.Setup;
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
    [TaskName("Setup")]
    [IsDependentOn(typeof(BuildTask))]
    public sealed class SetupTask : BaseTask
    {
        public override void Run(BuildContext context)
        {
        }
    }
}
