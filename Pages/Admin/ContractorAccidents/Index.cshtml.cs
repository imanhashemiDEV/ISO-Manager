using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.ContractorAccidents
{
    public class IndexModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbConText _conText;

        public IndexModel(ISO_Manager.Data.ApplicationDbConText conText)
        {
            _conText = conText;
        }

        public IList<ContractorAccident> ContractorAccident { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ContractorAccident = await _conText.ContractorAccidents
                .Include(c => c.User)
                .Include(c => c.Contractor)
                .ToListAsync();
        }
    }
}
