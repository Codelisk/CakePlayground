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
    [TaskName(nameof(DistributeAndroidTask))]
    [IsDependentOn(typeof(LoginTask))]
    public sealed class DistributeAndroidTask : BaseTask
    {
        public override void Run(BuildContext context)
        {
            var test = context.AppCenterDistributeReleaseWithResult(new AppCenterDistributeReleaseSettings
            {
                File = AppCenterConstants.AndroidFile,
                Group = AppCenterConstants.AndroidDistributionGroup,
                App = AppCenterConstants.AndroidApp,
                Token = AppCenterConstants.Token
            });
        }
    }
}
