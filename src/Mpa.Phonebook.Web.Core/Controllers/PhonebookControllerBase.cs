using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Mpa.Phonebook.Controllers
{
    public abstract class PhonebookControllerBase: AbpController
    {
        protected PhonebookControllerBase()
        {
            LocalizationSourceName = PhonebookConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
