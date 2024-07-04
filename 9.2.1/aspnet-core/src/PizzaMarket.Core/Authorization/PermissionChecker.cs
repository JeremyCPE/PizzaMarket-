using Abp.Authorization;
using PizzaMarket.Authorization.Roles;
using PizzaMarket.Authorization.Users;

namespace PizzaMarket.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
