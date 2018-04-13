using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Mpa.Phonebook.Controllers;

namespace Mpa.Phonebook.Web.Controllers
{
    [AbpMvcAuthorize]
    public class PersonbooksController : PhonebookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
