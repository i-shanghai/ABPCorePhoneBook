using Abp.AutoMapper;
using Mpa.Phonebook.Authentication.External;

namespace Mpa.Phonebook.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
