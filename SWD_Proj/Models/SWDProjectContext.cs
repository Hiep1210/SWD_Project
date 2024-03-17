using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SWD_Proj.Models
{
    public partial class SWDProjectContext : DbContext
    {
        public SWDProjectContext()
        {
        }

        public SWDProjectContext(DbContextOptions<SWDProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<Applicant> Applicants { get; set; } = null!;
        public virtual DbSet<Chat> Chats { get; set; } = null!;
        public virtual DbSet<ChatDetail> ChatDetails { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<Cv> Cvs { get; set; } = null!;
        public virtual DbSet<Employer> Employers { get; set; } = null!;
        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<JobDetail> JobDetails { get; set; } = null!;
        public virtual DbSet<Location> Locations { get; set; } = null!;
        public virtual DbSet<Profile> Profiles { get; set; } = null!;
        public virtual DbSet<RecruitmentPost> RecruitmentPosts { get; set; } = null!;
        public virtual DbSet<Submission> Submissions { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-5M0ARPK\\SQLEXPRESS;database=SWDProject;user=sa;password=123;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.AdminId)
                    .ValueGeneratedNever()
                    .HasColumnName("AdminID");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Admins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Admin__UserID__52593CB8");
            });

            modelBuilder.Entity<Applicant>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__Applican__C93A4F79451B61ED");

                entity.Property(e => e.ApplicationId)
                    .ValueGeneratedNever()
                    .HasColumnName("ApplicationID");

                entity.Property(e => e.Cvid).HasColumnName("CVID");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Cv)
                    .WithMany(p => p.Applicants)
                    .HasForeignKey(d => d.Cvid)
                    .HasConstraintName("FK__Applicants__CVID__5441852A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Applicants)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Applicant__UserI__534D60F1");
            });

            modelBuilder.Entity<Chat>(entity =>
            {
                entity.ToTable("Chat");

                entity.Property(e => e.ChatId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChatID");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Chats)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Chat__userID__5535A963");
            });

            modelBuilder.Entity<ChatDetail>(entity =>
            {
                entity.ToTable("ChatDetail");

                entity.Property(e => e.ChatDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("ChatDetailID");

                entity.Property(e => e.ChatId).HasColumnName("ChatID");

                entity.Property(e => e.Message).HasColumnType("text");

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.SenderId).HasColumnName("SenderID");

                entity.HasOne(d => d.Receiver)
                    .WithMany(p => p.ChatDetailReceivers)
                    .HasForeignKey(d => d.ReceiverId)
                    .HasConstraintName("FK__ChatDetai__Recei__5629CD9C");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.ChatDetailSenders)
                    .HasForeignKey(d => d.SenderId)
                    .HasConstraintName("FK__ChatDetai__Sende__571DF1D5");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.CommentId)
                    .ValueGeneratedNever()
                    .HasColumnName("CommentID");

                entity.Property(e => e.Message).HasColumnType("text");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK__Comment__PostID__5812160E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Comment__UserID__59063A47");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.CompanyId)
                    .ValueGeneratedNever()
                    .HasColumnName("CompanyID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cv>(entity =>
            {
                entity.ToTable("CV");

                entity.Property(e => e.Cvid)
                    .ValueGeneratedNever()
                    .HasColumnName("CVID");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Cvs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__CV__UserID__59FA5E80");
            });

            modelBuilder.Entity<Employer>(entity =>
            {
                entity.Property(e => e.EmployerId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmployerID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Department)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Employers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Employers__UserI__5AEE82B9");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job");

                entity.Property(e => e.JobId)
                    .ValueGeneratedNever()
                    .HasColumnName("JobID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__Job__CompanyID__5BE2A6F2");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK__Job__LocationID__5CD6CB2B");
            });

            modelBuilder.Entity<JobDetail>(entity =>
            {
                entity.ToTable("JobDetail");

                entity.Property(e => e.JobDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("JobDetailID");

                entity.Property(e => e.JobDescription).HasColumnType("text");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Requirement).HasColumnType("text");

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobDetails)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK__JobDetail__JobID__5DCAEF64");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(e => e.LocationId)
                    .ValueGeneratedNever()
                    .HasColumnName("LocationID");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.ToTable("Profile");

                entity.Property(e => e.ProfileId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProfileID");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Profiles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Profile__UserID__5EBF139D");
            });

            modelBuilder.Entity<RecruitmentPost>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PK__Recruitm__AA1260382C28EE21");

                entity.ToTable("RecruitmentPost");

                entity.Property(e => e.PostId)
                    .ValueGeneratedNever()
                    .HasColumnName("PostID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.RecruitmentPosts)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__Recruitme__Compa__5FB337D6");
            });

            modelBuilder.Entity<Submission>(entity =>
            {
                entity.Property(e => e.SubmissionId)
                    .ValueGeneratedNever()
                    .HasColumnName("SubmissionID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
