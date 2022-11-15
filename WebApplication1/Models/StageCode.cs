using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class StageCode
    {
        public StageCode()
        {
            AssetStageActions = new HashSet<AssetStageAction>();
        }

        public string Code { get; set; }

        public virtual Stage Stage { get; set; }
        public virtual ICollection<AssetStageAction> AssetStageActions { get; set; }
    }
}
