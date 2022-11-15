using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class ArticleAssetTypeFileExtension
    {
        public int Id { get; set; }
        public int ArticleAssetTypeId { get; set; }
        public int FileExtensionId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual AssetType ArticleAssetType { get; set; }
        public virtual FileExtension FileExtension { get; set; }
    }
}
