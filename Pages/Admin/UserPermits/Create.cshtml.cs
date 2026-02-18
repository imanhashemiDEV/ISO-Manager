using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.UserPermits
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
        ViewData["UserId"] = new SelectList(_conText.Users, "id", "name");
            return Page();
        }

        [BindProperty]
        public UserPermit UserPermit { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _conText.UserPermits.Add(UserPermit);
            await _conText.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
