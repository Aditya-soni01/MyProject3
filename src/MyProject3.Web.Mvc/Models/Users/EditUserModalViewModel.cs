using System.Collections.Generic;
using System.Linq;
using MyProject3.Roles.Dto;
using MyProject3.Users.Dto;

namespace MyProject3.Web.Models.Users
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
