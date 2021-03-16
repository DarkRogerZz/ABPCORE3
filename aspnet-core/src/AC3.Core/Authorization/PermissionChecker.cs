using Abp.Authorization;
using AC3.Authorization.Roles;
using AC3.Authorization.Users;

namespace AC3.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
