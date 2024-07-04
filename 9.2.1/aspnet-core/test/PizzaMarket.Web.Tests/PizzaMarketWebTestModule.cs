using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PizzaMarket.EntityFrameworkCore;
using PizzaMarket.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace PizzaMarket.Web.Tests
{
    [DependsOn(
        typeof(PizzaMarketWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class PizzaMarketWebTestModule : AbpModule
    {
        public PizzaMarketWebTestModule(PizzaMarketEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PizzaMarketWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(PizzaMarketWebMvcModule).Assembly);
        }
    }
}