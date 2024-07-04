using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PizzaMarket.EntityFrameworkCore
{
    public static class PizzaMarketDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PizzaMarketDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PizzaMarketDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
