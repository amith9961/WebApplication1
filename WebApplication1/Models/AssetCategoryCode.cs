using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class AssetCategoryCode
    {
        public AssetCategoryCode()
        {
            AssetCategories = new HashSet<AssetCategory>();
        }

        public string Code { get; set; }

        public virtual ICollection<AssetCategory> AssetCategories { get; set; }
    }
}
