using System.Collections.Generic;
using System.Linq;
using Mpa.Phonebook.Roles.Dto;
using Mpa.Phonebook.Users.Dto;

namespace Mpa.Phonebook.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
