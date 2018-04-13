using Abp.Runtime.Validation;
using Mpa.Phonebook.Dtos;

namespace Mpa.Phonebook.PhoneBook.Dtos
{
    /// <summary>
    /// 人员信息查询DTO
    /// </summary>
    public class GetPersonInput : PagedAndSortedInputDto, IShouldNormalize
    { 
        //查询关键字
        public string FilterText { get; set; }

        /// <summary>
        /// 实现接口，没有Sorting字段的情况下，根据Id排序
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
    }
}