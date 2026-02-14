using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.EmergencyTeams
{
    public class EditModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public EditModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EmergencyTeam EmergencyTeam { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergencyteam =  await _context.EmergencyTeams.FirstOrDefaultAsync(m => m.Id == id);
            if (emergencyteam == null)
            {
                return NotFound();
            }
            EmergencyTeam = emergencyteam;
           ViewData["duty_id"] = new SelectList(_context.Duties, "id", "id");
           ViewData["user_id"] = new SelectList(_context.Users, "id", "id");
           ViewData["workplace_id"] = new SelectList(_context.Workplaces, "id", "id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EmergencyTeam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmergencyTeamExists(EmergencyTeam.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmergencyTeamExists(long id)
        {
            return _context.EmergencyTeams.Any(e => e.Id == id);
        }
    }
}
