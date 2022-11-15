using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class AssetTypeSourceCode
    {
        public string Code { get; set; }

        public virtual AssetTypeSource AssetTypeSource { get; set; }
    }
}
