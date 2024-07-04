using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PizzaMarket.Configuration.Dto;

namespace PizzaMarket.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PizzaMarketAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
