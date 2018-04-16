using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;
using Mpa.Phonebook.PhoneBook.Persons;

namespace Mpa.Phonebook.PhoneBook.PhoneNumbers.Dto
{
    [AutoMapFrom(typeof(PhoneNumber))]
    public class PhoneNumberListDto
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// 电话类型
        /// </summary>
        public PhoneType PhoneType { get; set; }
    }
}
