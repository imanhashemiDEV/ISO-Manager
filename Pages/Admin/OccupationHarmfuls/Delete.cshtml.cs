using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.OccupationHarmfuls
{
    public class DeleteModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public DeleteModel(ISO_Manager.Data.ApplicationDbContext conText)
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

            var occupationharmful = await _conText.OccupationHarmfuls.FirstOrDefaultAsync(m => m.Id == id);

            if (occupationharmful is not null)
            {
                OccupationHarmful = occupationharmful;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var occupationharmful = await _conText.OccupationHarmfuls.FindAsync(id);
            if (occupationharmful != null)
            {
                OccupationHarmful = occupationharmful;
                _conText.OccupationHarmfuls.Remove(OccupationHarmful);
                await _conText.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
