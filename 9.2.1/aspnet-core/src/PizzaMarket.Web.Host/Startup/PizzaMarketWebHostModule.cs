using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PizzaMarket.Configuration;

namespace PizzaMarket.Web.Host.Startup
{
    [DependsOn(
       typeof(PizzaMarketWebCoreModule))]
    public class PizzaMarketWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PizzaMarketWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PizzaMarketWebHostModule).GetAssembly());
        }
    }
}
