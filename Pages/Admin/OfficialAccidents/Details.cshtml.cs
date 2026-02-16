using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.OfficialAccidents
{
    public class DetailsModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbConText _conText;

        public DetailsModel(ISO_Manager.Data.ApplicationDbConText conText)
        {
            _conText = conText;
        }

        public OfficialAccident OfficialAccident { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var officialaccident = await _conText.OfficialAccidents
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (officialaccident is not null)
            {
                OfficialAccident = officialaccident;

                return Page();
            }

            return NotFound();
        }
    }
}
