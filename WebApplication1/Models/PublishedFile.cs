using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class PublishedFile
    {
        public int Id { get; set; }
        public short SpaceId { get; set; }
        public int ArticleId { get; set; }
        public int AssetId { get; set; }
        public int FileId { get; set; }
        public string Comment { get; set; }
        public int LoggedInUserId { get; set; }
        public TimeSpan CreationDate { get; set; }
        public TimeSpan? ModificationDate { get; set; }
        public DateTime? ScheduledDateTime { get; set; }
        public string JobId { get; set; }
        public DateTime? PublishedDateTime { get; set; }
        public int? PublishedStatusId { get; set; }

        public virtual Article Article { get; set; }
        public virtual Asset Asset { get; set; }
        public virtual File File { get; set; }
        public virtual User LoggedInUser { get; set; }
        public virtual PublishedStatus PublishedStatus { get; set; }
    }
}
