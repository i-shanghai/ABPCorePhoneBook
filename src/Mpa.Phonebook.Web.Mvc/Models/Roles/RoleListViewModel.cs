using System.Collections.Generic;
using Mpa.Phonebook.Roles.Dto;

namespace Mpa.Phonebook.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
