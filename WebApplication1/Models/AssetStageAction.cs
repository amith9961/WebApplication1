using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class AssetStageAction
    {
        public string AssetType { get; set; }
        public string StageCode { get; set; }
        public string ActionType { get; set; }

        public virtual FileActionTypeCode ActionTypeNavigation { get; set; }
        public virtual AssetTypeCode AssetTypeNavigation { get; set; }
        public virtual StageCode StageCodeNavigation { get; set; }
    }
}
