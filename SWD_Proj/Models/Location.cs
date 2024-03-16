using System;
using System.Collections.Generic;

namespace SWD_Proj.Models
{
    public partial class Location
    {
        public Location()
        {
            Jobs = new HashSet<Job>();
        }

        public int LocationId { get; set; }
        public string? Company { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}
