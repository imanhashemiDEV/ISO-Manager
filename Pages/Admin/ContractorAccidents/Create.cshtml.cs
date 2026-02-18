using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.ContractorAccidents
{
    public class CreateModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public CreateModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
        }

        public IActionResult OnGet()
        {
        ViewData["contractors"] = new SelectList(_conText.Contractors, "id", "Company");
          ViewData["users"] = _conText.Users.Where(m => m.EmploymentType == "gharardadi" || m.EmploymentType=="peymankari").ToList();
            return Page();
        }

        [BindProperty]
        public ContractorAccident ContractorAccident { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _conText.ContractorAccidents.Add(ContractorAccident);
            await _conText.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
