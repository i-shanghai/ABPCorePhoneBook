using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Mpa.Phonebook.PhoneBook.PhoneNumbers;

namespace Mpa.Phonebook.PhoneBook.Persons
{
    /// <summary>
    /// 人员信息
    /// </summary>
    public class Person : FullAuditedEntity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }


        /// <summary>
        /// 地址
        /// </summary>
        [MaxLength(500)]
        public string Address { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}
