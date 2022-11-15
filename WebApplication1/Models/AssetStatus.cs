using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class AssetStatus
    {
        public AssetStatus()
        {
            Assets = new HashSet<Asset>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual AssetStatusCode CodeNavigation { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
    }
}
