using System.Threading.Tasks;
using Abp.Application.Services;
using PizzaMarket.Sessions.Dto;

namespace PizzaMarket.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
