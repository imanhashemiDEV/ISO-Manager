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

namespace ISO_Manager.Pages.Admin.RigAssets
{
    public class EditModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbConText _conText;

        public EditModel(ISO_Manager.Data.ApplicationDbConText conText)
        {
            _conText = conText;
        }

        [BindProperty]
        public RigAsset RigAsset { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rigasset =  await _conText.RigAssets.FirstOrDefaultAsync(m => m.Id == id);
            if (rigasset == null)
            {
                return NotFound();
            }
            RigAsset = rigasset;
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

            _conText.Attach(RigAsset).State = EntityState.Modified;

            try
            {
                await _conText.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RigAssetExists(RigAsset.Id))
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

        private bool RigAssetExists(long id)
        {
            return _conText.RigAssets.Any(e => e.Id == id);
        }
    }
}
