using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class PublishedKeyword
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Keyword { get; set; }
        public short SequenceNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public short SpaceId { get; set; }
    }
}
