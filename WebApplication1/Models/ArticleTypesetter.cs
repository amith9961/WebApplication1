using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class ArticleTypesetter
    {
        public int Id { get; set; }
        public bool IsCurrent { get; set; }
        public DateTime? AssignmentDate { get; set; }
        public string Comment { get; set; }
        public int? ArticleId { get; set; }
        public int? UserId { get; set; }
        public short SpaceId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual Typesetter Typesetter { get; set; }
    }
}
