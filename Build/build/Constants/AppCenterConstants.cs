using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build.Constants
{
    public static class AppCenterConstants
    {
        public const string AndroidToken = "45ebc7c38dfe4aa3e49c408077e3575aa1be6983";
        public const string IosToken = "4685bad124438b61cdc087562523c374adef2492";

        public static string AndroidFile = $"{GeneralConstants.APP_PACKAGE_FOLDER_NAME}/com.companyname.app1-Signed.apk";
        public const string iOSFile = $"{GeneralConstants.APP_PACKAGE_FOLDER_NAME}/Orderlyze.ipa";


        public const string AndroidApp = "Orderlyze/TestAndroid";

        public const string UserToken = "7f7f4f1da89a7fff77741841c6c4b2afb66e0afe";

        public const string AndroidDistributionGroup = "Collaborators";
        public const string IosDistributionGroup = "Dev";
        public const string AndroidDistributionGroupId = "6db33be4-e87e-4ae0-a718-4c34b4e91f6c";
        public const string IosDistributionGroupId = "1df984a7-e7a9-45f6-9be0-692f1c6223d0";
    }
}
