using System.Collections.Generic;
using Mpa.Phonebook.Roles.Dto;
using Mpa.Phonebook.Users.Dto;

namespace Mpa.Phonebook.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
