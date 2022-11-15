using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class CommentTypeCode
    {
        public string Code { get; set; }

        public virtual CommentType CommentType { get; set; }
    }
}
