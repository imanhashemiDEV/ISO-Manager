using ISO_Manager.Data;
using ISO_Manager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISO_Manager.Pages.Admin.InspectionDetails
{
    public class CreateModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbConText _conText;

        public CreateModel(ISO_Manager.Data.ApplicationDbConText conText)
        {
            _conText = conText;
        }

        public Inspection Inspection { get; set; } = default!;
        public IList<InspectionText> InspectionTexts { get; set; } = default!;

        [BindProperty]
        public int selectedInspection { get; set; }

        public async Task<IActionResult> OnGetAsync(int inspectionId)
        {
            selectedInspection = inspectionId;

            var inspection = await _conText.Inspections.FirstOrDefaultAsync(m => m.Id == inspectionId);
            var inspectionTexts = await _conText.InspectionTexts
                .Where(m=>m.InspectionPlaceId==inspection.InspectionPlaceId)
                .ToListAsync();

            if (inspection is not null)
            {
                Inspection = inspection;
                InspectionTexts = inspectionTexts;

                return Page();
            }

            return NotFound();
        }


        [BindProperty]
        public List<long> Checked { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var inspection = await _conText.Inspections.FirstOrDefaultAsync(m => m.Id == selectedInspection);

            foreach (var item in Checked)
            {
                
                var selected = await _conText.InspectionTexts.FindAsync(item);

                var detail = new InspectionDetail
                {
                    InspectionId = selectedInspection,
                    InspectionDate = inspection!.InspectionDate,
                    WorkPlaceId = inspection.WorkPlaceId,
                    TextId = (int) item,
                    Text = selected!.Text,
                    //Description = InspectionDescription
                };

                _conText.InspectionDetails.Add(detail);
                await _conText.SaveChangesAsync();
            }


            return RedirectToPage("/Admin/Inspections/Index");
        }


        
    }
}
