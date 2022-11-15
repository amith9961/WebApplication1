using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class PublishedArticle
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleTypeName { get; set; }
        public short Volume { get; set; }
        public int ElocationId { get; set; }
        public string Abstract { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public short SpaceId { get; set; }
    }
}
