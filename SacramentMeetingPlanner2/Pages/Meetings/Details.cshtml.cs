using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using SacramentMeetingPlanner2.Data;

namespace SacramentMeetingPlanner2.Pages.Meetings
{
    public class DetailsModel : PageModel
    {
        private readonly SacramentMeetingPlanner2.Data.SacramentMeetingPlanner2Context _context;

        public DetailsModel(SacramentMeetingPlanner2.Data.SacramentMeetingPlanner2Context context)
        {
            _context = context;
        }

        public Meeting Meeting { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meeting.FirstOrDefaultAsync(m => m.Id == id);

            if (meeting is not null)
            {
                Meeting = meeting;

                return Page();
            }

            return NotFound();
        }
    }
}
