using Abp.Runtime.Validation;
using Mpa.Phonebook.Dtos;

namespace Mpa.Phonebook.PhoneBook.Dtos
{
    public class GetPersonInput : PagedAndSortedInputDto, IShouldNormalize
    {

        public string FilterText { get; set; }

        /// <summary>
        /// 实现 接口
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