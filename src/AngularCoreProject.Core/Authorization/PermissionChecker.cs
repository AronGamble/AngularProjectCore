using Abp.Authorization;
using AngularCoreProject.Authorization.Roles;
using AngularCoreProject.Authorization.Users;

namespace AngularCoreProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
