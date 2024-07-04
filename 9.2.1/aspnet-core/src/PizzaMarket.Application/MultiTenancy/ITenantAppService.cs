using Abp.Application.Services;
using PizzaMarket.MultiTenancy.Dto;

namespace PizzaMarket.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

