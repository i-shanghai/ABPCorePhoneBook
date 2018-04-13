using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mpa.Phonebook.Controllers;

namespace Mpa.Phonebook.Web.Mvc.Controllers
{
    public class PersonController : PhonebookControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}