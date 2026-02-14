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
    public class DetailsModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public DetailsModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<InspectionText> InspectionText { get; set; } = default!;
        public InspectionPlace InspectionPlace { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            InspectionText = await _context.InspectionTexts
                .Include(i => i.InspectionPlace)
                .Where(m=>m.inspection_place_id==id)
                .OrderBy(n=>n.step)
                .ToListAsync();

            var inspectionPlace = await _context.InspectionPlaces.FirstOrDefaultAsync(m => m.Id == id);

            if (inspectionPlace is not null)
            {
                InspectionPlace = inspectionPlace;

                return Page();
            }

            return NotFound();
        }
    }
}
