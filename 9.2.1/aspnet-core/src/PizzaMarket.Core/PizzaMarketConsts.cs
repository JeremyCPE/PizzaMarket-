using PizzaMarket.Debugging;

namespace PizzaMarket
{
    public class PizzaMarketConsts
    {
        public const string LocalizationSourceName = "PizzaMarket";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "3c3728aaaaab4e45b64eaa55cab882fc";
    }
}
