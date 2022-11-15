using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class FileActionType
    {
        public FileActionType()
        {
            FileActions = new HashSet<FileAction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual FileActionTypeCode CodeNavigation { get; set; }
        public virtual ICollection<FileAction> FileActions { get; set; }
    }
}
