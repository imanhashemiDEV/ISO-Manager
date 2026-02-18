using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.Purposes
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
        ViewData["OrganizationId"] = new SelectList(_conText.Organizations, "id", "id");
            return Page();
        }

        [BindProperty]
        public Purpose Purpose { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _conText.Purposes.Add(Purpose);
            await _conText.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
