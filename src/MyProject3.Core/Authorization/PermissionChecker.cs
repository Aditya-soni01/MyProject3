using Abp.Authorization;
using MyProject3.Authorization.Roles;
using MyProject3.Authorization.Users;

namespace MyProject3.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
