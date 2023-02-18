using System.Collections.Generic;
using MyProject3.Roles.Dto;

namespace MyProject3.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
