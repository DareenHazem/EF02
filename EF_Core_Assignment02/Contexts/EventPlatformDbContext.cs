using EF_Core_Assignment02.Models;
using Microsoft.EntityFrameworkCore;
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

        public DbSet<Organizer> Organizer { get; set; }
        public DbSet<Attendee> Attendee { get; set; }
    }
}
