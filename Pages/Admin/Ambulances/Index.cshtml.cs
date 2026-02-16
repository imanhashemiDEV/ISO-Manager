using Azure;
using ISO_Manager.Data;
using ISO_Manager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ISO_Manager.Pages.Admin.Ambulances
{
    public class IndexModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbConText _conText;

        public IndexModel(ISO_Manager.Data.ApplicationDbConText conText)
        {
            _conText = conText;
        }

        public IList<Ambulance> Ambulances { get;set; } = default!;

        public async Task OnGetAsync(int pageId=1)
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

            Ambulances = await _conText.Ambulances
                .Include(a => a.User)
                .Include(a => a.WorkPlace)
                .Skip(skip).Take(Take)
                .ToListAsync();
        }
    }
}
