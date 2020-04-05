using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LuLuHobby.Models
{
    public partial class LuLuHobbyDataContext : DbContext
    {
        public LuLuHobbyDataContext()
        {
        }

        public LuLuHobbyDataContext(DbContextOptions<LuLuHobbyDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hobbies> Hobbies { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=LuLuHobbyData;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hobbies>(entity =>
            {
                entity.HasKey(e => e.HobbyId)
                    .HasName("PK__Hobbies__0ABE0BEFB0117FCC");

                entity.Property(e => e.HobbyId).HasColumnName("HobbyID");

                entity.Property(e => e.HobbyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HobbyType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PK__Location__E7FEA47738760828");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Lat)
                    .HasColumnName("lat")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Lng)
                    .HasColumnName("lng")
                    .HasColumnType("decimal(9, 6)");
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PK__Posts__AA126038607DDAA0");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.ContentUrl)
                    .HasColumnName("ContentURL")
                    .HasMaxLength(100);

                entity.Property(e => e.HobbyId).HasColumnName("HobbyID");

                entity.Property(e => e.PostDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Hobby)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.HobbyId)
                    .HasConstraintName("FK_dbo.Posts_dbo.Hobbies_HobbyID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.Posts_dbo.Users_UserID");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__1788CCACB3F5896F");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
