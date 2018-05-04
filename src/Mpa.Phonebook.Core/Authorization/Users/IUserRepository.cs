using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Mpa.Phonebook.Authorization.Users.Dtos;

namespace Mpa.Phonebook.Authorization.Users
{
    public interface IUserRepository:IRepository<User,long>
    {
        Task<List<string>> GetUserNames();

        Task<List<string>> GetAdminUsernames();

        Task DeleteUser(EntityDto input);

        Task UpdateEmail(UpdateEmailDto input);

        Task<GetUserByIdOutput> GetUserById(EntityDto input);
    }
}