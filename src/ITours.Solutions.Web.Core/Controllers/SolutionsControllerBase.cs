using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ITours.Solutions.Controllers
{
    public abstract class SolutionsControllerBase: AbpController
    {
        protected SolutionsControllerBase()
        {
            LocalizationSourceName = SolutionsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
