using System;
using System.Collections.Generic;

namespace SWD_Proj.Models
{
    public partial class Company
    {
        public Company()
        {
            Jobs = new HashSet<Job>();
            RecruitmentPosts = new HashSet<RecruitmentPost>();
        }

        public int CompanyId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<RecruitmentPost> RecruitmentPosts { get; set; }
    }
}
