using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Mpa.Phonebook.PhoneBook.Persons;

namespace Mpa.Phonebook.PhoneBook.Dtos
{
    /// <summary>
    /// 人员信息编辑DTO,定义编辑属性（是否必须，属性验证） :FullAuditedEntityDto  
    /// </summary>
    [AutoMapTo(typeof(Person))]
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