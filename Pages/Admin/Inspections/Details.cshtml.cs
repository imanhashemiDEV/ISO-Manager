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
    public class DetailsModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public DetailsModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Inspection Inspection { get; set; } = default!;
        public IList<InspectionDetail> InspectionDetails { get; set; } = default!;

        public IList<InspectionText> InspectionTexts { get; set; } = default!;

        public long selectedInspection { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            selectedInspection = (long)id;

            var inspection = await _context.Inspections.FirstOrDefaultAsync(m => m.Id == id);
            var inspectionDetails = await _context.InspectionDetails
                .Where(m => m.inspection_id == id)
                .ToListAsync();
            //var inspectionTexts = await _context.InspectionTexts
            //    .Where(m => m.inspection_place_id == inspection.inspection_place_id)
            //    .ToListAsync();


            if (inspectionDetails.Count == 0)
            {
                return RedirectToPage("/Admin/InspectionDetails/Create", new { inspectionId = inspection.Id.ToString() });
            }

            if (inspection is not null)
            {
                Inspection = inspection;
                InspectionDetails = inspectionDetails;
                //InspectionTexts = inspectionTexts;

                return Page();
            }

            return NotFound();
        }


        [BindProperty]
        public string InspectionDesc { get; set; }

        [BindProperty] 
        public long EditDetailId { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            var item = await _context.InspectionDetails.FindAsync(EditDetailId);

            item.description = InspectionDesc;
            _context.InspectionDetails.Update(item);
            await _context.SaveChangesAsync();


            return RedirectToPage("./Details", new {id = item.inspection_id.ToString()});
        }
    }
}
