using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PizzaMarket.Authorization;

namespace PizzaMarket
{
    [DependsOn(
        typeof(PizzaMarketCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PizzaMarketApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PizzaMarketAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PizzaMarketApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
