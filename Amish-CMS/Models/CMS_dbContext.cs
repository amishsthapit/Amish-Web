using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Amish_CMS.Models
{
    public partial class CMS_dbContext : DbContext
    {
        public CMS_dbContext()
        {
        }

        public CMS_dbContext(DbContextOptions<CMS_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ProfileSetting> ProfileSetting { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=127.0.0.1,14333;Initial Catalog=CMS_db;Persist Security Info=True;User ID=SA;Password=Amish@2016");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProfileSetting>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aboutme).IsUnicode(false);

                entity.Property(e => e.CoverPic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTs)
                    .HasColumnName("CreateTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FacebookLink)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InstagramLink)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LinkedinLink)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfilePic)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTs)
                    .HasColumnName("UpdateTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
