using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AC3.Configuration.Dto;

namespace AC3.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AC3AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
