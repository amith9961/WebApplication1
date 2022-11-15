using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Article
    {
        public Article()
        {
            PublishedFiles = new HashSet<PublishedFile>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? StageId { get; set; }
        public short SpaceId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? JournalId { get; set; }
        public DateTime? PublishedOn { get; set; }
        public DateTime? AcceptedOn { get; set; }

        public virtual ICollection<PublishedFile> PublishedFiles { get; set; }
    }
}
