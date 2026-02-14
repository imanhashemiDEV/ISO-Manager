using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.Inspections
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
        ViewData["inspection_place_id"] = new SelectList(_context.InspectionPlaces, "id", "title");
        ViewData["organization_id"] = new SelectList(_context.Organizations, "id", "title");
        ViewData["user_id"] = new SelectList(_context.Users, "id", "name");
        ViewData["workplace_id"] = new SelectList(_context.Workplaces, "id", "title");
            return Page();
        }

        [BindProperty]
        public Inspection Inspection { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Inspections.Add(Inspection);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
