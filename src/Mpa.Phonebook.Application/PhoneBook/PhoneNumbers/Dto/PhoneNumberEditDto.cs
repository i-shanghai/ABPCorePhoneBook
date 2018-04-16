using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.AutoMapper;
using Mpa.Phonebook.PhoneBook.Persons;
using Mpa.Phonebook.PhoneBook.PhoneNumbers;

namespace Mpa.Phonebook.PhoneBook.PhoneNumbers.Dto
{
    [AutoMapTo(typeof(PhoneNumber))]
   public class PhoneNumberEditDto
    {
        /// <summary>
        /// 号码
        /// </summary>
        [Required]
        [MaxLength(PhonebookConsts.MaxPhoneNoLength)]
        public string Number { get; set; }

        /// <summary>
        /// 电话类型
        /// </summary>
        public PhoneType PhoneType { get; set; }
         
    }
}
