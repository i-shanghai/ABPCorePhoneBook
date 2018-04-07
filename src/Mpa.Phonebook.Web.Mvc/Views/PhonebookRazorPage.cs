using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace Mpa.Phonebook.Web.Views
{
    public abstract class PhonebookRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PhonebookRazorPage()
        {
            LocalizationSourceName = PhonebookConsts.LocalizationSourceName;
        }
    }
}
