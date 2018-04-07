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
        /// 获取Person List
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input);

        /// <summary>
        /// 根据ID获取Person信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PersonListDto> GetPersonByIdAsync(GetPersonInput input);

        /// <summary>
        /// 新增或者修改人员信息
        /// </summary>
        /// <returns></returns>
        Task CreateOrUpdatePersonAsync();

        /// <summary>
        //删除人员信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeletePersonByIdAsync(EntityDto input);
    }
}