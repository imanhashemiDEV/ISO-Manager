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
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public EditModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
        }

        [BindProperty]
        public ClothGroupList ClothGroupList { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clothgrouplist =  await _conText.ClothGroupLists.FirstOrDefaultAsync(m => m.Id == id);
            if (clothgrouplist == null)
            {
                return NotFound();
            }
            ClothGroupList = clothgrouplist;
           ViewData["cloth_groups"] = _conText.ClothGroups.ToList();
           ViewData["users"] = _conText.Users.Where(m => m.EmploymentType == "rasmi" || m.EmploymentType == "gharardadi").ToList();
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

            _conText.Attach(ClothGroupList).State = EntityState.Modified;

            try
            {
                await _conText.SaveChangesAsync();
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
            return _conText.ClothGroupLists.Any(e => e.Id == id);
        }
    }
}
