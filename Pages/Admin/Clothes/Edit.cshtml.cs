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

namespace ISO_Manager.Pages.Admin.Clothes
{
    public class EditModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public EditModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
        }

        [BindProperty]
        public Cloth Cloth { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cloth =  await _conText.Clothes.FirstOrDefaultAsync(m => m.Id == id);
            if (cloth == null)
            {
                return NotFound();
            }
            Cloth = cloth;
           ViewData["OrganizationId"] = new SelectList(_conText.Organizations, "id", "id");
           ViewData["UserId"] = new SelectList(_conText.Users, "id", "id");
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

            _conText.Attach(Cloth).State = EntityState.Modified;

            try
            {
                await _conText.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClothExists(Cloth.Id))
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

        private bool ClothExists(long id)
        {
            return _conText.Clothes.Any(e => e.Id == id);
        }
    }
}
