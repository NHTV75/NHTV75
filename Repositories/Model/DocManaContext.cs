using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QuanLyHoSoDuAn.Model
{
    public partial class DocManaContext : DbContext
    {
        public DocManaContext() { }

        public DocManaContext(DbContextOptions<DocManaContext> options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<User_Department> User_Departments { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<User_Group> Users_Groups { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Project_Deparment> Project_Deparments { get; set; }
        public virtual DbSet<Project_Group> Project_Groups { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Profile_Document> Profiles_Documents { get; set; }
        public virtual DbSet<AccessPermission> AccessPermissions { get; set; }
        public virtual DbSet<GroupEmail> GroupEmails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserID).HasName("UserID_PK");

                entity.ToTable("Users");

                entity.Property(e => e.UserID).HasMaxLength(20).IsUnicode(false).HasColumnName("UserID");
                entity.Property(e => e.UserName).HasMaxLength(20).IsUnicode(false).HasColumnName("Username");
                entity.Property(e => e.Password).HasMaxLength(30).IsUnicode(false).HasColumnName("Password");
                entity.Property(e => e.FullName).HasMaxLength(30).IsUnicode(true).HasColumnName("FullName");
                entity.Property(e => e.Address).HasMaxLength(50).IsUnicode(true).HasColumnName("Address");
                entity.Property(e => e.Gender).HasMaxLength(10).IsUnicode(false).HasColumnName("Gender");
                entity.Property(e => e.Email).HasMaxLength(20).IsUnicode(false).HasColumnName("Email");
                entity.Property(e => e.Avatar).HasColumnName("Avatar");
                entity.Property(e => e.Role).HasMaxLength(10).IsUnicode(true).HasColumnName("Role");
                entity.Property(e => e.Status).HasMaxLength(20).IsUnicode(true).HasColumnName("Status");
                entity.Property(e => e.CreateDate).HasColumnName("CreateDate");
                entity.Property(e => e.ModifiedDate).HasColumnName("ModifiedDate");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DepartmentID).HasName("DepartmentID_PK");

                entity.ToTable("Departments");

                entity.Property(e => e.DepartmentID).HasMaxLength(20).IsUnicode(false).HasColumnName("DepartmentID");
                entity.Property(e => e.DepartmentName).HasMaxLength(20).IsUnicode(false).HasColumnName("DepartmentName");
                entity.Property(e => e.ManagerID).HasMaxLength(20).IsUnicode(false).HasColumnName("ManagerID");
                entity.Property(e => e.Description).HasMaxLength(50).IsUnicode(true).HasColumnName("Description");
                entity.Property(e => e.CreateDate).HasColumnName("CreateDate");
                entity.Property(e => e.ModifiedDate).HasColumnName("ModifiedDate");

                entity.HasOne(d => d.ManagerIDNavigation).WithOne(p => p.Department).HasForeignKey<Department>(d => d.ManagerID).HasConstraintName("ManagerID_Departments_FK");
            });

            modelBuilder.Entity<User_Department>(entity =>
            {
                //entity.HasKey(e => e.DepartmentID).HasName("DepartmentID_PK");

                entity.ToTable("User_Departments");

                entity.Property(e => e.UserID).HasMaxLength(20).IsUnicode(false).HasColumnName("UserID");
                entity.Property(e => e.DepartmentID).HasMaxLength(20).IsUnicode(false).HasColumnName("DepartmentID");
                entity.Property(e => e.Role).HasMaxLength(10).IsUnicode(true).HasColumnName("Role");
                entity.Property(e => e.AssignedDate).HasColumnName("AssignedDate");

                //entity.HasOne(d => d.UserIDNavigation).WithMany(p => p.User_Department).HasForeignKey<User_Department>(d => d.UserID).HasConstraintName("UserID_UserDepartments_FK");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(e => e.GroupID).HasName("Groups_PK");

                entity.ToTable("Groups");

                entity.Property(e => e.GroupID).HasMaxLength(20).IsUnicode(false).HasColumnName("GroupID");
                entity.Property(e => e.GroupName).HasMaxLength(30).IsUnicode(true).HasColumnName("GroupName");
                entity.Property(e => e.DeparmentID).HasMaxLength(20).IsUnicode(false).HasColumnName("DeparmentID");
                entity.Property(e => e.LeaderID).HasMaxLength(20).IsUnicode(false).HasColumnName("LeaderID");
                entity.Property(e => e.CreateDate).HasColumnName("CreateDate");
                entity.Property(e => e.ModifiedDate).HasColumnName("ModifiedDate");
            });

            modelBuilder.Entity<User_Group>(entity =>
            {
                //entity.HasKey(e => e.GroupID).HasName("Groups_PK");

                entity.ToTable("User_Groups");

                entity.Property(e => e.UserID).HasMaxLength(20).IsUnicode(false).HasColumnName("UserID");
                entity.Property(e => e.GroupID).HasMaxLength(20).IsUnicode(false).HasColumnName("GroupID");
                entity.Property(e => e.Role).HasMaxLength(10).IsUnicode(true).HasColumnName("Role");
                entity.Property(e => e.JoinedDate).HasColumnName("AssignedDate");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.ProjectID).HasName("ProjectID_PK");

                entity.ToTable("Projects");

                entity.Property(e => e.ProjectID).HasMaxLength(20).IsUnicode(false).HasColumnName("ProjectID");
                entity.Property(e => e.ProjectName).HasMaxLength(30).IsUnicode(true).HasColumnName("ProjectName");
                entity.Property(e => e.Description).HasMaxLength(50).IsUnicode(true).HasColumnName("Description");
                entity.Property(e => e.StartDate).HasColumnName("StartDate");
                entity.Property(e => e.EndDate).HasColumnName("EndDate");
                entity.Property(e => e.Status).HasMaxLength(30).IsUnicode(true).HasColumnName("EndDate");
                entity.Property(e => e.CreatedBy).HasMaxLength(20).IsUnicode(false).HasColumnName("CreatedBy");
                entity.Property(e => e.CreatedDate).HasColumnName("CreateDate");
                entity.Property(e => e.ModifiedDate).HasColumnName("ModifiedDate");
            });

            modelBuilder.Entity<Project_Deparment>(entity =>
            {
                //entity.HasKey(e => e.ProjectID).HasName("ProjectID_PK");

                entity.ToTable("Project_Deparments");

                entity.Property(e => e.ProjectID).HasMaxLength(20).IsUnicode(false).HasColumnName("ProjectID");
                entity.Property(e => e.DeparmentID).HasMaxLength(20).IsUnicode(false).HasColumnName("DeparmentID");
            });

            modelBuilder.Entity<Project_Group>(entity =>
            {
                //entity.HasKey(e => e.ProjectID).HasName("ProjectID_PK");

                entity.ToTable("Project_Groups");

                entity.Property(e => e.ProjectID).HasMaxLength(20).IsUnicode(false).HasColumnName("ProjectID");
                entity.Property(e => e.GroupID).HasMaxLength(20).IsUnicode(false).HasColumnName("GroupID");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasKey(e => e.ProfileID).HasName("ProfileID_PK");

                entity.ToTable("Profiles");

                entity.Property(e => e.ProfileID).HasMaxLength(20).IsUnicode(false).HasColumnName("ProfileID");
                entity.Property(e => e.ProjectID).HasMaxLength(20).IsUnicode(false).HasColumnName("ProjectID");
                entity.Property(e => e.ProfileName).HasMaxLength(30).IsUnicode(true).HasColumnName("ProfileName");
                entity.Property(e => e.Describe).HasMaxLength(50).IsUnicode(true).HasColumnName("Describe");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.DocumentID).HasName("DocumentID_PK");

                entity.ToTable("Documents");

                entity.Property(e => e.DocumentID).HasMaxLength(20).IsUnicode(false).HasColumnName("DocumentID");
                entity.Property(e => e.ProjectID).HasMaxLength(20).IsUnicode(false).HasColumnName("ProjectID");
                entity.Property(e => e.DocumentName).HasMaxLength(50).IsUnicode(true).HasColumnName("DocumentName");
                entity.Property(e => e.Version).HasMaxLength(20).IsUnicode(false).HasColumnName("Version");
                entity.Property(e => e.Status).HasMaxLength(50).IsUnicode(true).HasColumnName("Status");
                entity.Property(e => e.SubmittedBy).HasMaxLength(20).IsUnicode(false).HasColumnName("SubmittedBy");
                entity.Property(e => e.CreatedDate).HasColumnName("CreateDate");
                entity.Property(e => e.ModifiedDate).HasColumnName("ModifiedDate");
            });

            modelBuilder.Entity<Profile_Document>(entity =>
            {
                //entity.HasKey(e => e.DocumentID).HasName("DocumentID_PK");

                entity.ToTable("Profile_Documents");

                entity.Property(e => e.DocumentID).HasMaxLength(20).IsUnicode(false).HasColumnName("DocumentID");
                entity.Property(e => e.ProfileID).HasMaxLength(20).IsUnicode(false).HasColumnName("ProfileID");
            });

            modelBuilder.Entity<AccessPermission>(entity =>
            {
                entity.HasKey(e => e.PermissionID).HasName("PermissionID_PK");

                entity.ToTable("Profile_Documents");

                entity.Property(e => e.PermissionID).HasMaxLength(20).IsUnicode(false).HasColumnName("PermissionID");
                entity.Property(e => e.UserID).HasMaxLength(20).IsUnicode(false).HasColumnName("UserID");
                entity.Property(e => e.ProfileID).HasMaxLength(20).IsUnicode(false).HasColumnName("ProfileID");
                entity.Property(e => e.AccessLevel).HasMaxLength(50).IsUnicode(false).HasColumnName("AccessLevel");
            });

            modelBuilder.Entity<GroupEmail>(entity =>
            {
                entity.HasKey(e => e.EmailID).HasName("EmailID_PK");

                entity.ToTable("GroupEmails");

                entity.Property(e => e.EmailID).HasMaxLength(20).IsUnicode(false).HasColumnName("EmailID");
                entity.Property(e => e.SenderID).HasMaxLength(20).IsUnicode(false).HasColumnName("SenderID");
                entity.Property(e => e.ProfileID).HasMaxLength(20).IsUnicode(false).HasColumnName("ProfileID");
                entity.Property(e => e.Recipients).HasMaxLength(20).IsUnicode(false).HasColumnName("Recipients");
                entity.Property(e => e.CCList).HasMaxLength(50).IsUnicode(false).HasColumnName("CCList");
                entity.Property(e => e.Subject).IsUnicode(false).HasColumnName("Subject");
                entity.Property(e => e.Body).IsUnicode(true).HasColumnName("Body");
                entity.Property(e => e.SendDate).HasColumnName("SendDate");
            });
        }
    }
}