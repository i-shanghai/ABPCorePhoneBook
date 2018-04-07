using Abp.AutoMapper;
using Mpa.Phonebook.Sessions.Dto;

namespace Mpa.Phonebook.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
