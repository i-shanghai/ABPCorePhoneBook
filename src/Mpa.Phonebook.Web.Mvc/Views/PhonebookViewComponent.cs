using Abp.AspNetCore.Mvc.ViewComponents;

namespace Mpa.Phonebook.Web.Views
{
    public abstract class PhonebookViewComponent : AbpViewComponent
    {
        protected PhonebookViewComponent()
        {
            LocalizationSourceName = PhonebookConsts.LocalizationSourceName;
        }
    }
}
