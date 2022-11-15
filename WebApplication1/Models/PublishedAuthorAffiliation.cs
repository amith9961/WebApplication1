using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class PublishedAuthorAffiliation
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Institution { get; set; }
        public string Country { get; set; }
        public short SequenceNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public short SpaceId { get; set; }

        public virtual PublishedAuthorDetail Author { get; set; }
    }
}
