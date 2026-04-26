using EFAssignment02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssignment02.Context
{
    internal class EventHubDbContext :DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventHubDB;Trusted_Connection=True;TrustServerCertificate = true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EventHubDbContext).Assembly);
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Session> Sessions { get; set; }

    }
}
