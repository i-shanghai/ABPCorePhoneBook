using Abp.Authorization;
using Mpa.Phonebook.Authorization.Roles;
using Mpa.Phonebook.Authorization.Users;

namespace Mpa.Phonebook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
