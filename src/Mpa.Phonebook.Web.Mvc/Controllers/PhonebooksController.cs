using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Mpa.Phonebook.Controllers;

namespace Mpa.Phonebook.Web.Controllers
{
    [AbpMvcAuthorize]
    public class PersonController : PhonebookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
