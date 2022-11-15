using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class ZipContentFile
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Extension { get; set; }
        public int Size { get; set; }
        public string Path { get; set; }
        public int? TypeId { get; set; }
        public int FileId { get; set; }
        public int Id { get; set; }
        public short SpaceId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual ZipContentFileType Type { get; set; }
    }
}
