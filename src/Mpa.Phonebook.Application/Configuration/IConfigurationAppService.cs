using System.Threading.Tasks;
using Mpa.Phonebook.Configuration.Dto;

namespace Mpa.Phonebook.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
