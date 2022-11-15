using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class AssetType
    {
        public AssetType()
        {
            ArticleAssetTypeFileExtensions = new HashSet<ArticleAssetTypeFileExtension>();
            AssetTypeVisibilities = new HashSet<AssetTypeVisibility>();
            Assets = new HashSet<Asset>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Code { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? DefaultCategoryId { get; set; }

        public virtual AssetTypeSource Category { get; set; }
        public virtual AssetTypeCode CodeNavigation { get; set; }
        public virtual AssetCategory DefaultCategory { get; set; }
        public virtual ICollection<ArticleAssetTypeFileExtension> ArticleAssetTypeFileExtensions { get; set; }
        public virtual ICollection<AssetTypeVisibility> AssetTypeVisibilities { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
    }
}
