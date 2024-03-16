using System;
using System.Collections.Generic;

namespace SWD_Proj.Models
{
    public partial class JobDetail
    {
        public int JobDetailId { get; set; }
        public int? JobId { get; set; }
        public string? Title { get; set; }
        public double? Salary { get; set; }
        public string? Requirement { get; set; }
        public string? JobDescription { get; set; }

        public virtual Job? Job { get; set; }
    }
}
