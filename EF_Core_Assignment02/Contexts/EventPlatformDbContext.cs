using EF_Core_Assignment02.Configurations;
using EF_Core_Assignment02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment02.Contexts
{
    internal class EventPlatformDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventPlatformDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrganizerProfile>(entity =>
            {
                entity.HasKey(p => p.Id);

                entity.Property(p => p.Biography)
                      .HasMaxLength(200);

                entity.Property(p => p.Website)
                      .HasMaxLength(100);

                entity.Property(p => p.Logo)
                      .HasMaxLength(100);

                entity.HasOne(p => p.Organizer)
                      .WithOne(o => o.Profile)
                      .HasForeignKey<OrganizerProfile>(p => p.OrganizerId)
                      .IsRequired();
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Title)
                      .IsRequired()
                      .HasMaxLength(150);

                entity.Property(e => e.Description)
                      .IsRequired()
                      .HasMaxLength(250);

                entity.HasOne(e => e.Organizer)
                      .WithMany(o => o.Events)
                      .HasForeignKey(e => e.OrganizerId);
            });

            modelBuilder.ApplyConfiguration(new BadgeConfiguration());

        }

        public DbSet<Organizer> Organizer { get; set; }
        public DbSet<Attendee> Attendee { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Badge> Badges { get; set; }
    }
}
