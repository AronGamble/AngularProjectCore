using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AngularCoreProject.Controllers
{
    public abstract class AngularCoreProjectControllerBase: AbpController
    {
        protected AngularCoreProjectControllerBase()
        {
            LocalizationSourceName = AngularCoreProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
