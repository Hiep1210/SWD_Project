using System;
using System.Collections.Generic;

namespace SWD_Proj.Models
{
    public partial class RecruitmentPost
    {
        public RecruitmentPost()
        {
            Comments = new HashSet<Comment>();
        }

        public int PostId { get; set; }
        public int? CompanyId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public virtual Company? Company { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
