using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Stage
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        public virtual StageCode CodeNavigation { get; set; }
    }
}
