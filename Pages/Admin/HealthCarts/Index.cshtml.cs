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
    public class IndexModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public IndexModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<HealthCart> HealthCart { get;set; } = default!;

        public async Task OnGetAsync(int pageId = 1)
        {

            var Take = 10;
            var skip = (pageId - 1) * Take;
            var ItemCount = _context.HealthCarts.Count();
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

            HealthCart = await _context.HealthCarts
                .Include(h => h.User)
                .Include(h => h.WorkPlace)
                .Skip(skip).Take(Take)
                .OrderBy(m=>m.EndDate)
                .ToListAsync();
        }
    }
}
