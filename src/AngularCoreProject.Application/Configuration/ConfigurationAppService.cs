using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AngularCoreProject.Configuration.Dto;

namespace AngularCoreProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AngularCoreProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
