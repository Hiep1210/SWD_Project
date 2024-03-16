using System;
using System.Collections.Generic;

namespace SWD_Proj.Models
{
    public partial class User
    {
        public User()
        {
            Admins = new HashSet<Admin>();
            Applicants = new HashSet<Applicant>();
            ChatDetailReceivers = new HashSet<ChatDetail>();
            ChatDetailSenders = new HashSet<ChatDetail>();
            Chats = new HashSet<Chat>();
            Comments = new HashSet<Comment>();
            Cvs = new HashSet<Cv>();
            Employers = new HashSet<Employer>();
            Profiles = new HashSet<Profile>();
        }

        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Admin> Admins { get; set; }
        public virtual ICollection<Applicant> Applicants { get; set; }
        public virtual ICollection<ChatDetail> ChatDetailReceivers { get; set; }
        public virtual ICollection<ChatDetail> ChatDetailSenders { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Cv> Cvs { get; set; }
        public virtual ICollection<Employer> Employers { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
