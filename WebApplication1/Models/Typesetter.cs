using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Typesetter
    {
        public Typesetter()
        {
            ArticleTypesetters = new HashSet<ArticleTypesetter>();
            JournalTypesetters = new HashSet<JournalTypesetter>();
        }

        public int UserId { get; set; }
        public short SpaceId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public bool? IsDefault { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<ArticleTypesetter> ArticleTypesetters { get; set; }
        public virtual ICollection<JournalTypesetter> JournalTypesetters { get; set; }
    }
}
