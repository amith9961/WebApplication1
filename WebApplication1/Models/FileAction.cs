using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class FileAction
    {
        public int Id { get; set; }
        public int FileId { get; set; }
        public string Comment { get; set; }
        public DateTime Timestamp { get; set; }
        public int TypeId { get; set; }
        public int? UserId { get; set; }
        public short SpaceId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual FileActionType Type { get; set; }
        public virtual User User { get; set; }
    }
}
