using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Mpa.Phonebook.Controllers;

namespace Mpa.Phonebook.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : PhonebookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
