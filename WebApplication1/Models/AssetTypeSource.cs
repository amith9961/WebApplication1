using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class AssetTypeSource
    {
        public AssetTypeSource()
        {
            AssetTypes = new HashSet<AssetType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual AssetTypeSourceCode CodeNavigation { get; set; }
        public virtual ICollection<AssetType> AssetTypes { get; set; }
    }
}
