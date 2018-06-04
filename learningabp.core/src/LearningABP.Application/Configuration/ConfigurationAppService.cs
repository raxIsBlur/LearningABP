using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using LearningABP.Configuration.Dto;

namespace LearningABP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LearningABPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
