using System;
using System.Collections.Generic;

namespace SWD_Proj.Models
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public int? UserId { get; set; }
        public string? Role { get; set; }

        public virtual User? User { get; set; }
    }
}
