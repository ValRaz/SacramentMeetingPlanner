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
    public class DeleteModel : PageModel
    {
        private readonly SacramentMeetingPlanner2.Data.SacramentMeetingPlanner2Context _context;

        public DeleteModel(SacramentMeetingPlanner2.Data.SacramentMeetingPlanner2Context context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meeting.FindAsync(id);
            if (meeting != null)
            {
                Meeting = meeting;
                _context.Meeting.Remove(Meeting);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
