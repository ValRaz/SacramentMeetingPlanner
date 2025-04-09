using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using SacramentMeetingPlanner2.Data;

namespace SacramentMeetingPlanner2.Pages.Meetings
{
    public class IndexModel : PageModel
    {
        private readonly SacramentMeetingPlanner2.Data.SacramentMeetingPlanner2Context _context;

        public IndexModel(SacramentMeetingPlanner2.Data.SacramentMeetingPlanner2Context context)
        {
            _context = context;
        }

        public IList<Meeting> Meeting { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? TalkSubjects { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? ConductingLeader { get; set; }

        public async Task OnGetAsync()
        {
            var meetings = from m in _context.Meeting
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                meetings = meetings.Where(s => s.TalkSubjects.Contains(SearchString));
            }

            Meeting = await meetings.ToListAsync();
        }
    }
}
