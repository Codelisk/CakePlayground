using Build.Constants;
using Build.Tasks.Base;
using Build.Tasks.General.Setup;
using Cake.AppCenter;
using Cake.Common.IO;
using Cake.Frosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build.Tasks.General.AppCenter
{
    [TaskName("Login")]
    [IsDependentOn(typeof(SetupTask))]
    public sealed class LoginTask : BaseTask
    {
        public override void Run(BuildContext context)
        {
            context.AppCenterLogin(new AppCenterLoginSettings
            {
                Token = AppCenterConstants.AndroidToken
            });
        }
    }
}
