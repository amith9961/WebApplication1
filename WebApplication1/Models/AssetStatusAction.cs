using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class AssetStatusAction
    {
        public string AssetType { get; set; }
        public string StatusCode { get; set; }
        public string ActionType { get; set; }

        public virtual FileActionTypeCode ActionTypeNavigation { get; set; }
        public virtual AssetTypeCode AssetTypeNavigation { get; set; }
        public virtual FileStatusCode StatusCodeNavigation { get; set; }
    }
}
