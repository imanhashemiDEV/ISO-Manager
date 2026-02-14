using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.Inspections
{
    public class IndexModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public IndexModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Inspection> Inspection { get;set; } = default!;

        public async Task OnGetAsync(int pageId = 1)
        {
            var Take = 30;
            var skip = (pageId - 1) * Take;
            var ItemCount = _context.Inspections.Count();
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

            Inspection = await _context.Inspections
                .Include(i => i.InspectionPlace)
                //.Include(i => i.Organization)
                .Include(i => i.User)
                .Include(i => i.Workplace)
                .OrderByDescending(m => m.Id)
                .Skip(skip).Take(Take)
                .ToListAsync();
        }
    }
}
