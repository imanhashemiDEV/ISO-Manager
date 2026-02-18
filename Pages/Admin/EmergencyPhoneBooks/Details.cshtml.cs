using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.EmergencyPhoneBooks
{
    public class DetailsModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public DetailsModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
        }

        public EmergencyPhoneBook EmergencyPhoneBook { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergencyphonebook = await _conText.EmergencyPhoneBooks.FirstOrDefaultAsync(m => m.Id == id);

            if (emergencyphonebook is not null)
            {
                EmergencyPhoneBook = emergencyphonebook;

                return Page();
            }

            return NotFound();
        }
    }
}
