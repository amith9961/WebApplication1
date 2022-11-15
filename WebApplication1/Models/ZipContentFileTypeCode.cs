using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class ZipContentFileTypeCode
    {
        public string Code { get; set; }

        public virtual ZipContentFileType ZipContentFileType { get; set; }
    }
}
