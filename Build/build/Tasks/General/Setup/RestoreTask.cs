using Build.Constants;
using Build.Tasks.Base;
using Cake.Common.Tools.DotNet;
using Cake.Frosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build.Tasks.General.Setup
{
    [TaskName("Restore")]
    [IsDependentOn(typeof(CleanTask))]
    public sealed class RestoreTask : BaseTask
    {
        public override void Run(BuildContext context)
        {
            context.DotNetRestore(GeneralConstants.SlnPath);
        }
    }
}
