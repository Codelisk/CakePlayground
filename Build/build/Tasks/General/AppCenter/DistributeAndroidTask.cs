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
    [TaskName("DsitributeAndroid")]
    [IsDependentOn(typeof(LoginTask))]
    public sealed class DsitributeAndroidTask : BaseTask
    {
        public override void Run(BuildContext context)
        {
            var test = context.AppCenterDistributeReleaseWithResult(new AppCenterDistributeReleaseSettings
            {
                File = AppCenterConstants.AndroidFile,
                Group = AppCenterConstants.AndroidDistributionGroup,
                App = AppCenterConstants.AndroidApp,
                Token = AppCenterConstants.AndroidToken
            });
        }
    }
}
