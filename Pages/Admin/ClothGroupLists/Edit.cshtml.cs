using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.ClothGroupLists
{
    public class EditModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public EditModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ClothGroupList ClothGroupList { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clothgrouplist =  await _context.ClothGroupLists.FirstOrDefaultAsync(m => m.Id == id);
            if (clothgrouplist == null)
            {
                return NotFound();
            }
            ClothGroupList = clothgrouplist;
           ViewData["cloth_groups"] = _context.ClothGroups.ToList();
           ViewData["users"] = _context.Users.Where(m => m.EmploymentType == "rasmi" || m.EmploymentType == "gharardadi").ToList();
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ClothGroupList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClothGroupListExists(ClothGroupList.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("/Admin/ClothGroups/Index");
        }

        private bool ClothGroupListExists(long id)
        {
            return _context.ClothGroupLists.Any(e => e.Id == id);
        }
    }
}
