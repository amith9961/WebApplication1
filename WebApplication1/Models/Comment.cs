using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int TypeId { get; set; }
        public short SpaceId { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? CommentModificationDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual CommentType Type { get; set; }
    }
}
