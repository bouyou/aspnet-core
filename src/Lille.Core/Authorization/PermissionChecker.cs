using Abp.Authorization;
using Lille.Authorization.Roles;
using Lille.Authorization.Users;

namespace Lille.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
