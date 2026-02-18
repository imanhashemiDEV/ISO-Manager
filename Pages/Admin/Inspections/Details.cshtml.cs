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
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public DetailsModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
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

            var inspection = await _conText.Inspections.FirstOrDefaultAsync(m => m.Id == id);
            var inspectionDetails = await _conText.InspectionDetails
                .Where(m => m.InspectionId == id)
                .ToListAsync();
            //var inspectionTexts = await _conText.InspectionTexts
            //    .Where(m => m.InspectionPlaceId == inspection.InspectionPlaceId)
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

            var item = await _conText.InspectionDetails.FindAsync(EditDetailId);

            item.Description = InspectionDesc;
            _conText.InspectionDetails.Update(item);
            await _conText.SaveChangesAsync();


            return RedirectToPage("./Details", new {id = item.InspectionId.ToString()});
        }
    }
}
