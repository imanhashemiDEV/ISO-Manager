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

namespace ISO_Manager.Pages.Admin.Inspectiontexts
{
    public class EditModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public EditModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Inspectiontext Inspectiontext { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inspectiontext =  await _context.Inspectiontexts.FirstOrDefaultAsync(m => m.Id == id);
            if (inspectiontext == null)
            {
                return NotFound();
            }
            Inspectiontext = inspectiontext;
           ViewData["InspectionPlaceId"] = new SelectList(_context.InspectionPlaces, "id", "id");
           ViewData["OrganizationId"] = new SelectList(_context.Organizations, "id", "id");
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

            _context.Attach(Inspectiontext).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InspectiontextExists(Inspectiontext.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("/Admin/InspectionPlaces/Index");
        }

        private bool InspectiontextExists(long id)
        {
            return _context.Inspectiontexts.Any(e => e.Id == id);
        }
    }
}
