using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.OperationPlans
{
    public class IndexModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public IndexModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
        }

        public IList<OperationPlan> OperationPlan { get;set; } = default!;

        public async Task OnGetAsync(int pageId = 1)
        {
            var Take = 10;
            var skip = (pageId - 1) * Take;
            var ItemCount = _conText.Ambulances.Count();
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

            OperationPlan = await _conText.OperationPlans
                .Include(o => o.Purpose)
                .Skip(skip).Take(Take)
                .ToListAsync();
        }
    }
}
