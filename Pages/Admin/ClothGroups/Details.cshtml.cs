using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.ClothGroups
{
    public class DetailsModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public DetailsModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public ClothGroup ClothGroup { get; set; } = default!;
        public IList<ClothGroupList> ClothGroupList { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id, int pageId = 1)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Take = 10;
            var skip = (pageId - 1) * Take;
            var ItemCount = _context.ClothGroupLists.Count(m => m.ClothGroupId == id);
            ViewData["ItemCount"] = ItemCount;
            ViewData["Take"] = Take;
            ViewData["pageId"] = pageId;

            if (ItemCount % Take == 0)
            {
                ViewData["PageCount"] = (ItemCount / Take);
            }
            else
            {
                ViewData["PageCount"] = (ItemCount / Take) + 1;
            }

            ClothGroupList = await _context.ClothGroupLists
                .Include(c => c.ClothGroup)
                .Include(c => c.User)
                .Where(m=>m.ClothGroupId== id)
                .Skip(skip).Take(Take)
                .ToListAsync();

            var clothgroup = await _context.ClothGroups.FirstOrDefaultAsync(m => m.Id == id);

            if (clothgroup is not null)
            {
                ClothGroup = clothgroup;

                return Page();
            }

            return NotFound();
        }
    }
}
