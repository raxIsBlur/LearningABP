using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LearningABP.Controllers
{
    public abstract class LearningABPControllerBase: AbpController
    {
        protected LearningABPControllerBase()
        {
            LocalizationSourceName = LearningABPConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
