using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class UploadRequest
    {
        public UploadRequest()
        {
            UploadRequestFiles = new HashSet<UploadRequestFile>();
        }

        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public string Comments { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string Token { get; set; }
        public int? UserId { get; set; }
        public int? ArticleId { get; set; }
        public short SpaceId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<UploadRequestFile> UploadRequestFiles { get; set; }
    }
}
