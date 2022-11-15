using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class PublishedStatus
    {
        public PublishedStatus()
        {
            ArticleJobs = new HashSet<ArticleJob>();
            PublishedFiles = new HashSet<PublishedFile>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual PublishedStatusesCode CodeNavigation { get; set; }
        public virtual ICollection<ArticleJob> ArticleJobs { get; set; }
        public virtual ICollection<PublishedFile> PublishedFiles { get; set; }
    }
}
