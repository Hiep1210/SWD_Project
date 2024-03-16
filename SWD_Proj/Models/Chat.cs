using System;
using System.Collections.Generic;

namespace SWD_Proj.Models
{
    public partial class Chat
    {
        public int ChatId { get; set; }
        public int? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
