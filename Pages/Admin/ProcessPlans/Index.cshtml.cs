using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.ProcessPlans
{
    public class IndexModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbConText _conText;

        public IndexModel(ISO_Manager.Data.ApplicationDbConText conText)
        {
            _conText = conText;
        }

        public IList<ProcessPlan> ProcessPlan { get;set; } = default!;

        public async Task OnGetAsync(long id , int pageId = 1)
        {
            var Take = 10;
            var skip = (pageId - 1) * Take;
            var ItemCount = _conText.ProcessPlans.Count();
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
            ProcessPlan = await _conText.ProcessPlans
                .Where(m=>m.process_id == id)
                .Include(p => p.Process)
                .Skip(skip).Take(Take)
                .ToListAsync();
        }
    }
}
