using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class FileStatusCode
    {
        public FileStatusCode()
        {
            AssetStatusActions = new HashSet<AssetStatusAction>();
        }

        public string Code { get; set; }

        public virtual FileStatus FileStatus { get; set; }
        public virtual ICollection<AssetStatusAction> AssetStatusActions { get; set; }
    }
}
