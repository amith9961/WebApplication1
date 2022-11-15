using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class ZipContentFileType
    {
        public ZipContentFileType()
        {
            ZipContentFiles = new HashSet<ZipContentFile>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual ZipContentFileTypeCode CodeNavigation { get; set; }
        public virtual ICollection<ZipContentFile> ZipContentFiles { get; set; }
    }
}
