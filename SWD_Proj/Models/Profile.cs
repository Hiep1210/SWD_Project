using System;
using System.Collections.Generic;

namespace SWD_Proj.Models
{
    public partial class Profile
    {
        public int ProfileId { get; set; }
        public int? UserId { get; set; }
        public string? FullName { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        public virtual User? User { get; set; }
    }
}
