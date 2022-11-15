using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class PublishedAuthorDetail
    {
        public PublishedAuthorDetail()
        {
            PublishedAuthorAffiliations = new HashSet<PublishedAuthorAffiliation>();
        }

        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsCorrespondingAuthor { get; set; }
        public string EmailId { get; set; }
        public short SequenceNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public short SpaceId { get; set; }

        public virtual ICollection<PublishedAuthorAffiliation> PublishedAuthorAffiliations { get; set; }
    }
}
