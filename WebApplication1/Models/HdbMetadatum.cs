using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class HdbMetadatum
    {
        public int Id { get; set; }
        public string Metadata { get; set; }
        public int ResourceVersion { get; set; }
    }
}
