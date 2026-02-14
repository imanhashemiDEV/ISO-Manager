using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.HealthCarts
{
    public class DeleteModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public DeleteModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HealthCart HealthCart { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthcart = await _context.HealthCarts.FirstOrDefaultAsync(m => m.Id == id);

            if (healthcart is not null)
            {
                HealthCart = healthcart;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var healthcart = await _context.HealthCarts.FindAsync(id);
            if (healthcart != null)
            {
                HealthCart = healthcart;
                _context.HealthCarts.Remove(HealthCart);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
