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

namespace ISO_Manager.Pages.Admin.InspectionDetails
{
    public class EditModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public EditModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public InspectionDetail InspectionDetail { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inspectiondetail =  await _context.InspectionDetails.FirstOrDefaultAsync(m => m.Id == id);
            if (inspectiondetail == null)
            {
                return NotFound();
            }
            InspectionDetail = inspectiondetail;
           ViewData["InspectionId"] = new SelectList(_context.Inspections, "id", "id");
           ViewData["textId"] = new SelectList(_context.Inspectiontexts, "id", "id");
           ViewData["WorkPlaceId"] = new SelectList(_context.WorkPlaces, "id", "id");
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

            _context.Attach(InspectionDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InspectionDetailExists(InspectionDetail.Id))
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

        private bool InspectionDetailExists(long id)
        {
            return _context.InspectionDetails.Any(e => e.Id == id);
        }
    }
}
