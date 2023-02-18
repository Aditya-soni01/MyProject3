using System.Collections.Generic;
using MyProject3.Roles.Dto;

namespace MyProject3.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}