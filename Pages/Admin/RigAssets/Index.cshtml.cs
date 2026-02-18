using ISO_Manager.Data;
using ISO_Manager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ISO_Manager.Pages.Admin.RigAssets
{
    public class IndexModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public IndexModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
        }

        public IList<RigAsset> RigAsset { get;set; } = default!;

        [BindProperty]
        public string Search { get; set; }
        public async Task OnGetAsync()
        {

            var persianCulture = new CultureInfo("fa-IR");
            var comparer = StringComparer.Create(persianCulture, false);


            RigAsset = await _conText.RigAssets
                .Where(m => m.Place == "rig-102")
                .OrderBy(x => x.AssetName)
                .ToListAsync();
        }

        public async Task OnPostAsync()
        {
            RigAsset = await _conText.RigAssets
                .Where(m => m.Place == Search)
                .ToListAsync();

        }
    }
}
