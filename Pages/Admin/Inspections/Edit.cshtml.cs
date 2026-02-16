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

namespace ISO_Manager.Pages.Admin.Inspections
{
    public class EditModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbConText _conText;

        public EditModel(ISO_Manager.Data.ApplicationDbConText conText)
        {
            _conText = conText;
        }

        [BindProperty]
        public Inspection Inspection { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inspection =  await _conText.Inspections.FirstOrDefaultAsync(m => m.Id == id);
            if (inspection == null)
            {
                return NotFound();
            }
            Inspection = inspection;
           ViewData["InspectionPlaceId"] = new SelectList(_conText.InspectionPlaces, "id", "Title");
           ViewData["OrganizationId"] = new SelectList(_conText.Organizations, "id", "Title");
           ViewData["UserId"] = new SelectList(_conText.Users, "id", "name");
           ViewData["WorkPlaceId"] = new SelectList(_conText.WorkPlaces, "id", "Title");
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

            _conText.Attach(Inspection).State = EntityState.Modified;

            try
            {
                await _conText.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InspectionExists(Inspection.Id))
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

        private bool InspectionExists(long id)
        {
            return _conText.Inspections.Any(e => e.Id == id);
        }
    }
}
