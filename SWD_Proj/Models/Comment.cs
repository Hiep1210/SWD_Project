using System;
using System.Collections.Generic;

namespace SWD_Proj.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public int? PostId { get; set; }
        public int? UserId { get; set; }
        public string? Message { get; set; }

        public virtual RecruitmentPost? Post { get; set; }
        public virtual User? User { get; set; }
    }
}
