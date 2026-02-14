using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.ClothGroupLists
{
    public class CreateModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public CreateModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public long ClothGroupId { get; set; }

        public IActionResult OnGet(long id)
        {
            ViewData["cloth_groups"] = _context.ClothGroups.ToList();
            ViewData["users"] = _context.Users.Where(m => m.employment_type == "rasmi" || m.employment_type == "gharardadi").ToList();
            ClothGroupId = id;
            return Page();
        }

        [BindProperty]
        public ClothGroupList ClothGroupList { get; set; } = default!;



        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ClothGroupLists.Add(ClothGroupList);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Admin/ClothGroups/Index");
        }
    }
}
