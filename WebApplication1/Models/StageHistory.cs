using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class StageHistory
    {
        public DateTime StartDate { get; set; }
        public int StageId { get; set; }
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public short SpaceId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
    }
}
