using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.RigAssets
{
    public class DeleteModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public DeleteModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RigAsset RigAsset { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rigasset = await _context.RigAssets.FirstOrDefaultAsync(m => m.Id == id);

            if (rigasset is not null)
            {
                RigAsset = rigasset;

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

            var rigasset = await _context.RigAssets.FindAsync(id);
            if (rigasset != null)
            {
                RigAsset = rigasset;
                _context.RigAssets.Remove(RigAsset);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
