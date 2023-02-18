using System.Collections.Generic;
using MyProject3.Roles.Dto;

namespace MyProject3.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
