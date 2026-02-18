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

namespace ISO_Manager.Pages.Admin.OfficialAccidents
{
    public class EditModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public EditModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
        }

        [BindProperty]
        public OfficialAccident OfficialAccident { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var officialaccident =  await _conText.OfficialAccidents.FirstOrDefaultAsync(m => m.Id == id);
            if (officialaccident == null)
            {
                return NotFound();
            }
            OfficialAccident = officialaccident;
            ViewData["users"] = _conText.Users.Where(m => m.EmploymentType == "rasmi").ToList();
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

            _conText.Attach(OfficialAccident).State = EntityState.Modified;

            try
            {
                await _conText.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OfficialAccidentExists(OfficialAccident.Id))
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

        private bool OfficialAccidentExists(long id)
        {
            return _conText.OfficialAccidents.Any(e => e.Id == id);
        }
    }
}
