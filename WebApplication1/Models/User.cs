using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class User
    {
        public User()
        {
            Assets = new HashSet<Asset>();
            FileActions = new HashSet<FileAction>();
            PublishedFiles = new HashSet<PublishedFile>();
            Typesetters = new HashSet<Typesetter>();
            UploadRequests = new HashSet<UploadRequest>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<FileAction> FileActions { get; set; }
        public virtual ICollection<PublishedFile> PublishedFiles { get; set; }
        public virtual ICollection<Typesetter> Typesetters { get; set; }
        public virtual ICollection<UploadRequest> UploadRequests { get; set; }
    }
}
