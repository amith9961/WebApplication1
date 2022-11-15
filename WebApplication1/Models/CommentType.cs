using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class CommentType
    {
        public CommentType()
        {
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual CommentTypeCode CodeNavigation { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
