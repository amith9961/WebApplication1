using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class RoleCode
    {
        public RoleCode()
        {
            AssetRoleActions = new HashSet<AssetRoleAction>();
        }

        public string Code { get; set; }

        public virtual ICollection<AssetRoleAction> AssetRoleActions { get; set; }
    }
}
