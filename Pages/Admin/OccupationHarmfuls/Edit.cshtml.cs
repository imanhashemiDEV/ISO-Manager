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

namespace ISO_Manager.Pages.Admin.OccupationHarmfuls
{
    public class EditModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public EditModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
        }

        [BindProperty]
        public OccupationHarmful OccupationHarmful { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var occupationharmful =  await _conText.OccupationHarmfuls.FirstOrDefaultAsync(m => m.Id == id);
            if (occupationharmful == null)
            {
                return NotFound();
            }
            OccupationHarmful = occupationharmful;
           ViewData["HarmfulFactorId"] = new SelectList(_conText.Set<HarmfulFactor>(), "id", "id");
           ViewData["OccupationId"] = new SelectList(_conText.Occupations, "id", "id");
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

            _conText.Attach(OccupationHarmful).State = EntityState.Modified;

            try
            {
                await _conText.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OccupationHarmfulExists(OccupationHarmful.Id))
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

        private bool OccupationHarmfulExists(long id)
        {
            return _conText.OccupationHarmfuls.Any(e => e.Id == id);
        }
    }
}
