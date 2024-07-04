using System.Threading.Tasks;
using PizzaMarket.Configuration.Dto;

namespace PizzaMarket.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
