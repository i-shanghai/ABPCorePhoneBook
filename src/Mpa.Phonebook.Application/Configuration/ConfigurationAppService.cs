using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Mpa.Phonebook.Configuration.Dto;

namespace Mpa.Phonebook.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PhonebookAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
