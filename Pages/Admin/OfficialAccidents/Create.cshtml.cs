using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.OfficialAccidents
{
    public class CreateModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public CreateModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["users"] = _context.Users.Where(m => m.employment_type == "rasmi").ToList();
            return Page();
        }

        [BindProperty]
        public OfficialAccident OfficialAccident { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

          

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.OfficialAccidents.Add(OfficialAccident);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
