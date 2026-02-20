using ISO_Manager.Data;
using ISO_Manager.Models;
using ISO_Manager.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISO_Manager.Pages.Admin.Clothes
{
    public class EditModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public EditModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DateTime ReceivedDate { get; set; }

        [BindProperty]
        public Cloth Cloth { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cloth =  await _context.Clothes.FirstOrDefaultAsync(m => m.Id == id);
            if (cloth == null)
            {
                return NotFound();
            }
            Cloth = cloth;
           ViewData["OrganizationId"] = new SelectList(_context.Organizations, "id", "id");
           ViewData["UserId"] = new SelectList(_context.Users, "id", "id");
            ReceivedDate = DateToPersian.ToShamsiDate(cloth.ReceiveDate);
            return Page();
        }

      
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Cloth.ReceiveDate = DateToMiladi.ToMiladi(ReceivedDate);

            _context.Attach(Cloth).State = EntityState.Modified;
             await _context.SaveChangesAsync();
            
          

            return RedirectToPage("./Index");
        }

        private bool ClothExists(int id)
        {
            return _context.Clothes.Any(e => e.Id == id);
        }
    }
}
