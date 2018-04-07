using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Mpa.Phonebook.PhoneBook.Persons;

namespace Mpa.Phonebook.PhoneBook.PhoneNumbers
{
    /// <summary>
    /// 电话号码
    /// </summary>
    public class PhoneNumber:Entity<long>, IHasCreationTime
    {
        /// <summary>
        /// 号码
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Number { get; set; }

        /// <summary>
        /// 电话类型
        /// </summary>
        public PhoneType PhoneType { get; set; }


        public long PersonId { get; set; }

        public Person Person { get; set; }


        public DateTime CreationTime { get; set; }
    }
}
