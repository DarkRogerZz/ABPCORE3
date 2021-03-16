using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AC3.Controllers
{
    public abstract class AC3ControllerBase: AbpController
    {
        protected AC3ControllerBase()
        {
            LocalizationSourceName = AC3Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
