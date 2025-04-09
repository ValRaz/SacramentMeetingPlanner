using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace SacramentMeetingPlanner2.Data
{
    public class SacramentMeetingPlanner2Context : DbContext
    {
        public SacramentMeetingPlanner2Context (DbContextOptions<SacramentMeetingPlanner2Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Meeting> Meeting { get; set; } = default!;
    }
}
