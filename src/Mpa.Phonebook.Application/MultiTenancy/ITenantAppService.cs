using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Mpa.Phonebook.MultiTenancy.Dto;

namespace Mpa.Phonebook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
