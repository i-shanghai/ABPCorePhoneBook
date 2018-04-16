using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using Mpa.Phonebook.Controllers;
using Mpa.Phonebook.PhoneBook;
using Mpa.Phonebook.PhoneBook.Dtos;

namespace Mpa.Phonebook.Web.Mvc.Controllers
{
    public class PersonController : PhonebookControllerBase
    {
        private readonly IPersonAppService _personAppServices;

        public PersonController(IPersonAppService personAppServices)
        {
            _personAppServices = personAppServices;
        }

        public async Task<IActionResult> Index(GetPersonInput input )
        {
            PagedResultDto<PersonListDto> dtos =  await _personAppServices.GetPagedPersonAsync(input);

            return View(dtos);
        }
    }
}