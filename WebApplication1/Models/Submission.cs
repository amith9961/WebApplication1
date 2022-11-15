using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Submission
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Type { get; set; }
        public string Doi { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string JournalName { get; set; }
        public string SectionName { get; set; }
        public int SpaceId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? SectionId { get; set; }
        public int? ArticleTypeId { get; set; }
    }
}
