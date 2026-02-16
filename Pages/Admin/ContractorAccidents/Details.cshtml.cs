using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.ContractorAccidents
{
    public class DetailsModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbConText _conText;

        public DetailsModel(ISO_Manager.Data.ApplicationDbConText conText)
        {
            _conText = conText;
        }

        public ContractorAccident ContractorAccident { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contractoraccident = await _conText.ContractorAccidents
                .Include(m=>m.User)
                .Include(m=>m.Contractor)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (contractoraccident is not null)
            {
                ContractorAccident = contractoraccident;

                return Page();
            }

            return NotFound();
        }
    }
}
