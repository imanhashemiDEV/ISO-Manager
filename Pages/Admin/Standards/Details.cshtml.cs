using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.Standards
{
    public class DetailsModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public DetailsModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
        }

        public Standard Standard { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var standard = await _conText.Standards.FirstOrDefaultAsync(m => m.Id == id);

            if (standard is not null)
            {
                Standard = standard;

                return Page();
            }

            return NotFound();
        }
    }
}
