﻿using System;
using System.Collections.Generic;

namespace SWD_Proj.Models
{
    public partial class Cv
    {
        public Cv()
        {
            Applicants = new HashSet<Applicant>();
        }

        public int Cvid { get; set; }
        public int? UserId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<Applicant> Applicants { get; set; }
    }
}
