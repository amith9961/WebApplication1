using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class ArticleJob
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string JobId { get; set; }
        public short SpaceId { get; set; }
        public DateTime CreationDate { get; set; }
        public int LastActionUserId { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? Status { get; set; }
        public string Summary { get; set; }

        public virtual PublishedStatus StatusNavigation { get; set; }
    }
}
