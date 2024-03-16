using System;
using System.Collections.Generic;

namespace SWD_Proj.Models
{
    public partial class Applicant
    {
        public int ApplicationId { get; set; }
        public int? UserId { get; set; }
        public int? JobId { get; set; }
        public int? Cvid { get; set; }
        public string? Status { get; set; }

        public virtual Cv? Cv { get; set; }
        public virtual User? User { get; set; }
    }
}
