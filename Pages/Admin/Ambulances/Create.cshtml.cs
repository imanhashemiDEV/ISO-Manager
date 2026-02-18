using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ISO_Manager.Data;
using ISO_Manager.Models;
using Microsoft.AspNetCore.Authorization;

namespace ISO_Manager.Pages.Admin.Ambulances
{
    public class CreateModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public CreateModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
        }

       // [Authorize]
        public IActionResult OnGet()
        {
            ViewData["users"] = _conText.Users.ToList();
            ViewData["workPlaces"] = _conText.WorkPlaces.ToList();
            return Page();
        }

        [BindProperty]
        public Ambulance Ambulance { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _conText.Ambulances.Add(Ambulance);
            await _conText.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
