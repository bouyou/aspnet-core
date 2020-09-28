using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Lille.Controllers
{
    public abstract class LilleControllerBase: AbpController
    {
        protected LilleControllerBase()
        {
            LocalizationSourceName = LilleConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
