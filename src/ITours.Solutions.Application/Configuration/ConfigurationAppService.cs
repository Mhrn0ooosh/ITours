using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ITours.Solutions.Configuration.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ITours.Solutions.Configuration
{
    [AbpAuthorize]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ConfigurationAppService : SolutionsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
