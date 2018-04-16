using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Mpa.Phonebook.PhoneBook.Dtos;

namespace Mpa.Phonebook.PhoneBook
{
    /// <summary>
    /// PersonService 接口,定义需要实现的CRUD
    /// </summary>
    public interface IPersonAppService:IApplicationService
    {
        /// <summary>
        /// 获取联系人信息列表,GetPersonInput 带有分布和关键字查找属性
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input);

        /// <summary>
        /// 根据ID获取联系人信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input);

        /// <summary>
        /// 新增或者修改联系人信息
        /// </summary>
        /// <returns></returns>
        Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonDto input);

        /// <summary>
        /// 通过Id获取联系人信息,给编辑信息备用
        /// </summary>
        Task<GetPersonForEditOutput> GetPersonForEditAsync(NullableIdDto<int> input);


        /// <summary>
        //删除联系人信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeletePersonAsync(EntityDto input); 
          
    }
}