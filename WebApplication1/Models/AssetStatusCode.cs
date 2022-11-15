using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class AssetStatusCode
    {
        public string Code { get; set; }

        public virtual AssetStatus AssetStatus { get; set; }
    }
}
