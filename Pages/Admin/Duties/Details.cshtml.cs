using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.Duties
{
    public class DetailsModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public DetailsModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Duty Duty { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duty = await _context.Duties.FirstOrDefaultAsync(m => m.Id == id);

            if (duty is not null)
            {
                Duty = duty;

                return Page();
            }

            return NotFound();
        }
    }
}
