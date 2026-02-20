using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.Inspectiontexts
{
    public class CreateModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public CreateModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public long PlaceId { get; set; }

        public IActionResult OnGet(long? id)
        {
            PlaceId = (long)id;
        ViewData["InspectionPlaceId"] = new SelectList(_context.InspectionPlaces, "id", "id");
        ViewData["OrganizationId"] = new SelectList(_context.Organizations, "id", "id");
            return Page();
        }

        [BindProperty]
        public Inspectiontext Inspectiontext { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Inspectiontexts.Add(Inspectiontext);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Admin/InspectionPlaces/Index");
        }
    }
}
