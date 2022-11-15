using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class AssetRoleAction
    {
        public string AssetType { get; set; }
        public string RoleCode { get; set; }
        public string ActionType { get; set; }

        public virtual FileActionTypeCode ActionTypeNavigation { get; set; }
        public virtual AssetTypeCode AssetTypeNavigation { get; set; }
        public virtual RoleCode RoleCodeNavigation { get; set; }
    }
}
