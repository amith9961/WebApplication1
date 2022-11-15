using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Asset
    {
        public Asset()
        {
            PublishedFiles = new HashSet<PublishedFile>();
        }

        public int Id { get; set; }
        public int StatusId { get; set; }
        public int? ArticleId { get; set; }
        public int TypeId { get; set; }
        public short SpaceId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? ProductionArticleAssetNumber { get; set; }
        public int? CategoryId { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Name { get; set; }
        public int? AssetNumber { get; set; }

        public virtual AssetCategory Category { get; set; }
        public virtual User ModifiedByNavigation { get; set; }
        public virtual AssetStatus Status { get; set; }
        public virtual AssetType Type { get; set; }
        public virtual ICollection<PublishedFile> PublishedFiles { get; set; }
    }
}
