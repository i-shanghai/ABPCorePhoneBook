using System.Threading.Tasks;
using Abp.Application.Services;
using Mpa.Phonebook.Sessions.Dto;

namespace Mpa.Phonebook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
