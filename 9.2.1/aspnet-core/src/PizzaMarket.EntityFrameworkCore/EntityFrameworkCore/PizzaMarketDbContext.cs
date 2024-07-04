using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PizzaMarket.Authorization.Roles;
using PizzaMarket.Authorization.Users;
using PizzaMarket.MultiTenancy;

namespace PizzaMarket.EntityFrameworkCore
{
    public class PizzaMarketDbContext : AbpZeroDbContext<Tenant, Role, User, PizzaMarketDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public PizzaMarketDbContext(DbContextOptions<PizzaMarketDbContext> options)
            : base(options)
        {
        }
    }
}
