using Build.Constants;
using Build.Tasks.Base;
using Cake.AppCenter;
using Cake.Frosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build.Tasks.General.AppCenter
{
    [TaskName(nameof(DistributeIosTask))]
    [IsDependentOn(typeof(LoginTask))]
    public sealed class DistributeIosTask : BaseTask
    {
        public override void Run(BuildContext context)
        {
            var test = context.AppCenterDistributeReleaseWithResult(new AppCenterDistributeReleaseSettings
            {
                File = AppCenterConstants.iOSFile,
                Group = AppCenterConstants.IosDistributionGroup,
                App = AppCenterConstants.IosApp,
                Token = AppCenterConstants.AndroidToken
            });
        }
    }
}
