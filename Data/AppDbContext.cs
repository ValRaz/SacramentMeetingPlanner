using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<SacramentMeeting> SacramentMeetings { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
    }
}
