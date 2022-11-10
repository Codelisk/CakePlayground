using Build.Constants;
using Build.Tasks.Base;
using Cake.Common.IO;
using Cake.Frosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build.Tasks.General.Setup
{
    [TaskName(nameof(CleanTask))]
    public sealed class CleanTask : BaseTask
    {
        public override void Run(BuildContext context)
        {
            context.CleanDirectory(GeneralConstants.BinPath(context.MsBuildConfiguration));
        }
    }
}
