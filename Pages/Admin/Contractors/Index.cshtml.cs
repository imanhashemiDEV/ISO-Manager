using Azure;
using ISO_Manager.Data;
using ISO_Manager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISO_Manager.Pages.Admin.Contractors
{
    public class IndexModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public IndexModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
        }

        public IList<Contractor> Contractor { get;set; } = default!;

        public async Task OnGetAsync(int pageId = 1)
        {
            var Take = 10;
            var skip = (pageId - 1) * Take;
            var ItemCount = _conText.Contractors.Count();
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

            Contractor = await _conText.Contractors
                .OrderBy(m=>m.Status)
                .ThenBy(m=>m.EndDate)
                .ToListAsync();
        }
    }
}
