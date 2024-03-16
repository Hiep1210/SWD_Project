using System;
using System.Collections.Generic;

namespace SWD_Proj.Models
{
    public partial class Employer
    {
        public int EmployerId { get; set; }
        public int? CompanyId { get; set; }
        public int? UserId { get; set; }
        public string? Position { get; set; }
        public string? Department { get; set; }

        public virtual User? User { get; set; }
    }
}
