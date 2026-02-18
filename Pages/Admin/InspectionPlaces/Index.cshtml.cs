using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.InspectionPlaces
{
    public class IndexModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public IndexModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
        }

        public IList<InspectionPlace> InspectionPlace { get;set; } = default!;

        public async Task OnGetAsync()
        {
            InspectionPlace = await _conText.InspectionPlaces
                //.Include(i => i.Organization)
                .ToListAsync();
        }
    }
}
