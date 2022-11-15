using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class PublishedStatusesCode
    {
        public string Code { get; set; }

        public virtual PublishedStatus PublishedStatus { get; set; }
    }
}
