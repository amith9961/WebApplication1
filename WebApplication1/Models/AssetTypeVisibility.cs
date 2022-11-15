using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class AssetTypeVisibility
    {
        public int AssetTypeId { get; set; }
        public string HasuraRole { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual AssetType AssetType { get; set; }
    }
}
