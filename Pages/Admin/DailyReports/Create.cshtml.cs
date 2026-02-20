using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.DailyReports
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
        ViewData["CampBossId"] = new SelectList(_context.Users, "id", "name");
        ViewData["DoctorId"] = new SelectList(_context.Users, "id", "name");
        ViewData["RigBossId"] = new SelectList(_context.Users, "id", "name");
            return Page();
        }

        [BindProperty]
        public DailyReport DailyReport { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DailyReports.Add(DailyReport);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
