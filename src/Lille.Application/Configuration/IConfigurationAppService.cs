using System.Threading.Tasks;
using Lille.Configuration.Dto;

namespace Lille.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
