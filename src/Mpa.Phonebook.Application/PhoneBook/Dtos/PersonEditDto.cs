using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace Mpa.Phonebook.PhoneBook.Dtos
{
    public class PersonEditDto  
    {
        public int? Id { get; set; }

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
    }
}