using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.EmergencyTeams
{
    public class DetailsModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public DetailsModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public EmergencyTeam EmergencyTeam { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergencyteam = await _context.EmergencyTeams.FirstOrDefaultAsync(m => m.Id == id);

            if (emergencyteam is not null)
            {
                EmergencyTeam = emergencyteam;

                return Page();
            }

            return NotFound();
        }
    }
}
