using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.InspectionTexts
{
    public class CreateModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbConText _conText;

        public CreateModel(ISO_Manager.Data.ApplicationDbConText conText)
        {
            _conText = conText;
        }

        public long PlaceId { get; set; }

        public IActionResult OnGet(long? id)
        {
            PlaceId = (long)id;
        ViewData["InspectionPlaceId"] = new SelectList(_conText.InspectionPlaces, "id", "id");
        ViewData["OrganizationId"] = new SelectList(_conText.Organizations, "id", "id");
            return Page();
        }

        [BindProperty]
        public InspectionText InspectionText { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _conText.InspectionTexts.Add(InspectionText);
            await _conText.SaveChangesAsync();

            return RedirectToPage("/Admin/InspectionPlaces/Index");
        }
    }
}
