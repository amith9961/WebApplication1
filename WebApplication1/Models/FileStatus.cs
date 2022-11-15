using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class FileStatus
    {
        public FileStatus()
        {
            Files = new HashSet<File>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual FileStatusCode CodeNavigation { get; set; }
        public virtual ICollection<File> Files { get; set; }
    }
}
