using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class AssetCategory
    {
        public AssetCategory()
        {
            AssetTypes = new HashSet<AssetType>();
            Assets = new HashSet<Asset>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual AssetCategoryCode CodeNavigation { get; set; }
        public virtual ICollection<AssetType> AssetTypes { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
    }
}
