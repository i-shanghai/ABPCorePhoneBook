using System.Threading.Tasks;
using Abp.Application.Services;
using Mpa.Phonebook.Authorization.Accounts.Dto;

namespace Mpa.Phonebook.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
