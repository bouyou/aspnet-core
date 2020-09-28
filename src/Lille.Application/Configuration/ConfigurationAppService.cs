using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Lille.Configuration.Dto;

namespace Lille.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LilleAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
