using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PizzaMarket.Localization
{
    public static class PizzaMarketLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PizzaMarketConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PizzaMarketLocalizationConfigurer).GetAssembly(),
                        "PizzaMarket.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
