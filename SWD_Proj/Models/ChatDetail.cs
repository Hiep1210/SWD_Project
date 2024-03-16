using System;
using System.Collections.Generic;

namespace SWD_Proj.Models
{
    public partial class ChatDetail
    {
        public int ChatDetailId { get; set; }
        public int? ChatId { get; set; }
        public int? SenderId { get; set; }
        public int? ReceiverId { get; set; }
        public string? Message { get; set; }
        public DateTime? SendTime { get; set; }

        public virtual User? Receiver { get; set; }
        public virtual User? Sender { get; set; }
    }
}
