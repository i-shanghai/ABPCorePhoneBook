using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Mpa.Phonebook.Authorization.Users.Dtos;
using Mpa.Phonebook.Roles.Dto;
using Mpa.Phonebook.Users.Dto;

namespace Mpa.Phonebook.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<List<string>> GetUsers();

        Task<List<string>> GetAdminUsernames();

        Task DeleteUser(EntityDto input);

        Task UpdateEmail(UpdateEmailDto input);

        Task<GetUserByIdOutput> GetUserById(EntityDto input);
    }
}
