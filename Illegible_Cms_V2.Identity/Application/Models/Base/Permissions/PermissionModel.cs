﻿using Illegible_Cms_V2.Identity.Application.Models.Base.Roles;
using Illegible_Cms_V2.Identity.Application.Models.Base.Users;
using Illegible_Cms_V2.Identity.Domain.Roles;

namespace Illegible_Cms_V2.Identity.Application.Models.Base.Permissions
{
    public class PermissionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatorId { get; set; }
        #region Navigations

        public UserModel Creator { get; set; }
        public ICollection<RolePermissionModel> Roles { get; set; }

        #endregion
    }
}
