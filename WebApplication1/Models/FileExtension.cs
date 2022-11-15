using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class FileExtension
    {
        public FileExtension()
        {
            ArticleAssetTypeFileExtensions = new HashSet<ArticleAssetTypeFileExtension>();
        }

        public int Id { get; set; }
        public string Extension { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual ICollection<ArticleAssetTypeFileExtension> ArticleAssetTypeFileExtensions { get; set; }
    }
}
