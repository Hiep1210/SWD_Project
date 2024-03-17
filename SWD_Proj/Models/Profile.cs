using System;
using System.Collections.Generic;

namespace SWD_Proj.Models
{
    public partial class Profile
    {
        public Profile()
        {
            Cvs = new HashSet<Cv>();
        }

        public int ProfileId { get; set; }
        public int? UserId { get; set; }
        public string? FullName { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<Cv> Cvs { get; set; }
    }
}
