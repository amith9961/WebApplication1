using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class File
    {
        public File()
        {
            PublishedFiles = new HashSet<PublishedFile>();
        }

        public int Id { get; set; }
        public string OriginalName { get; set; }
        public string FileServerId { get; set; }
        public int Size { get; set; }
        public int Version { get; set; }
        public bool? IsLatest { get; set; }
        public DateTime LastActionDate { get; set; }
        public int? StatusId { get; set; }
        public int? LastActionUserId { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public int? AssetId { get; set; }
        public short SpaceId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string ErrorMessage { get; set; }

        public virtual FileStatus Status { get; set; }
        public virtual ICollection<PublishedFile> PublishedFiles { get; set; }
    }
}
