using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class UploadRequestFile
    {
        public int Id { get; set; }
        public string Extension { get; set; }
        public DateTime? ProvisionDate { get; set; }
        public int? AssetId { get; set; }
        public int? UploadRequestId { get; set; }
        public int? OriginalFileId { get; set; }
        public short SpaceId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual UploadRequest UploadRequest { get; set; }
    }
}
