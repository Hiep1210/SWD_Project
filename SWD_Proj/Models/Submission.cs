using System;
using System.Collections.Generic;

namespace SWD_Proj.Models
{
    public partial class Submission
    {
        public int SubmissionId { get; set; }
        public int? ApplicationId { get; set; }
        public int? CommentId { get; set; }
    }
}
