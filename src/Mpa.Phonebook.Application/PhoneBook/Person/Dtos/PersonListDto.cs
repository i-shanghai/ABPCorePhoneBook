 
using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Mpa.Phonebook.PhoneBook.Persons;
using Mpa.Phonebook.PhoneBook.PhoneNumbers;
using Mpa.Phonebook.PhoneBook.PhoneNumbers.Dto;

namespace Mpa.Phonebook.PhoneBook.Dtos
{
    /// <summary>
    /// 从Person映射出来到ListDto里面
    /// </summary>
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto:FullAuditedEntityDto 
    {
         /// <summary>
        /// 姓名
        /// </summary> 
        public string Name { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary> 
        public string Email { get; set; }


        /// <summary>
        /// 地址
        /// </summary> 
        public string Address { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public List<PhoneNumberListDto> PhoneNumbers { get; set; }
    }
}