using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class AssetTypeCode
    {
        public AssetTypeCode()
        {
            AssetRoleActions = new HashSet<AssetRoleAction>();
            AssetStageActions = new HashSet<AssetStageAction>();
            AssetStatusActions = new HashSet<AssetStatusAction>();
        }

        public string Code { get; set; }

        public virtual AssetType AssetType { get; set; }
        public virtual ICollection<AssetRoleAction> AssetRoleActions { get; set; }
        public virtual ICollection<AssetStageAction> AssetStageActions { get; set; }
        public virtual ICollection<AssetStatusAction> AssetStatusActions { get; set; }
    }
}
