using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.EmergencyTeams
{
    public class CreateModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbConText _conText;

        public CreateModel(ISO_Manager.Data.ApplicationDbConText conText)
        {
            _conText = conText;
        }

        public IActionResult OnGet()
        {
        ViewData["DutyId"] = new SelectList(_conText.Duties, "id", "id");
        ViewData["UserId"] = new SelectList(_conText.Users, "id", "id");
        ViewData["WorkPlaceId"] = new SelectList(_conText.WorkPlaces, "id", "id");
            return Page();
        }

        [BindProperty]
        public EmergencyTeam EmergencyTeam { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _conText.EmergencyTeams.Add(EmergencyTeam);
            await _conText.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
