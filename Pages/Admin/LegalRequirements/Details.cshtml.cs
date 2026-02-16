using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.LegalRequirements
{
    public class DetailsModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbConText _conText;

        public DetailsModel(ISO_Manager.Data.ApplicationDbConText conText)
        {
            _conText = conText;
        }

        public LegalRequirement LegalRequirement { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var legalrequirement = await _conText.LegalRequirements.FirstOrDefaultAsync(m => m.Id == id);

            if (legalrequirement is not null)
            {
                LegalRequirement = legalrequirement;

                return Page();
            }

            return NotFound();
        }
    }
}
