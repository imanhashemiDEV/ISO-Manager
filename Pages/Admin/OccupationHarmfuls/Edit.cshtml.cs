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
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public EditModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OccupationHarmful OccupationHarmful { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var occupationharmful =  await _context.OccupationHarmfuls.FirstOrDefaultAsync(m => m.Id == id);
            if (occupationharmful == null)
            {
                return NotFound();
            }
            OccupationHarmful = occupationharmful;
           ViewData["harmful_factor_id"] = new SelectList(_context.Set<HarmfulFactor>(), "id", "id");
           ViewData["occupation_id"] = new SelectList(_context.Occupations, "id", "id");
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

            _context.Attach(OccupationHarmful).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
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
            return _context.OccupationHarmfuls.Any(e => e.Id == id);
        }
    }
}
