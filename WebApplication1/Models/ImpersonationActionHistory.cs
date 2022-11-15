using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class ImpersonationActionHistory
    {
        public int Id { get; set; }
        public int LoggedInUserId { get; set; }
        public int ImpersonatedUserId { get; set; }
        public string ImpersonatedRole { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Comment { get; set; }
        public int SpaceId { get; set; }
        public int ArticleId { get; set; }
    }
}
