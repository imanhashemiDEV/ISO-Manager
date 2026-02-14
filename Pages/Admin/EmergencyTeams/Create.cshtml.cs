using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.EmergencyTeams
{
    public class CreateModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public CreateModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["duty_id"] = new SelectList(_context.Duties, "id", "id");
        ViewData["user_id"] = new SelectList(_context.Users, "id", "id");
        ViewData["workplace_id"] = new SelectList(_context.Workplaces, "id", "id");
            return Page();
        }

        [BindProperty]
        public EmergencyTeam EmergencyTeam { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.EmergencyTeams.Add(EmergencyTeam);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
