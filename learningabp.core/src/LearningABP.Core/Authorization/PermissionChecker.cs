using Abp.Authorization;
using LearningABP.Authorization.Roles;
using LearningABP.Authorization.Users;

namespace LearningABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
