using Abp.Authorization;
using ITours.Solutions.Authorization.Roles;
using ITours.Solutions.Authorization.Users;

namespace ITours.Solutions.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
