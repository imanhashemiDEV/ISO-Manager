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

namespace ISO_Manager.Pages.Admin.ContractorAccidents
{
    public class EditModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public EditModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
        }

        [BindProperty]
        public ContractorAccident ContractorAccident { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contractoraccident =  await _conText.ContractorAccidents.FirstOrDefaultAsync(m => m.Id == id);
            if (contractoraccident == null)
            {
                return NotFound();
            }
            ContractorAccident = contractoraccident;
           ViewData["contractors"] = new SelectList(_conText.Contractors, "id", "Company");
           ViewData["users"] = _conText.Users.Where(m => m.EmploymentType == "gharardadi" || m.EmploymentType == "peymankari").ToList();
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

            _conText.Attach(ContractorAccident).State = EntityState.Modified;

            try
            {
                await _conText.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContractorAccidentExists(ContractorAccident.Id))
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

        private bool ContractorAccidentExists(long id)
        {
            return _conText.ContractorAccidents.Any(e => e.Id == id);
        }
    }
}
