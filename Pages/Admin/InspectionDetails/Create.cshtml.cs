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
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public CreateModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Inspection Inspection { get; set; } = default!;
        public IList<InspectionText> InspectionTexts { get; set; } = default!;

        [BindProperty]
        public int selectedInspection { get; set; }

        public async Task<IActionResult> OnGetAsync(int inspectionId)
        {
            selectedInspection = inspectionId;

            var inspection = await _context.Inspections.FirstOrDefaultAsync(m => m.Id == inspectionId);
            var inspectionTexts = await _context.InspectionTexts
                .Where(m=>m.inspection_place_id==inspection.inspection_place_id)
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
            var inspection = await _context.Inspections.FirstOrDefaultAsync(m => m.Id == selectedInspection);

            foreach (var item in Checked)
            {
                
                var selected = await _context.InspectionTexts.FindAsync(item);

                var detail = new InspectionDetail
                {
                    inspection_id = selectedInspection,
                    inspection_date = inspection.inspection_date,
                    workplace_id = inspection.workplace_id,
                    text_id = (int) item,
                    text = selected.text,
                    //description = InspectionDescription
                };

                _context.InspectionDetails.Add(detail);
                await _context.SaveChangesAsync();
            }


            return RedirectToPage("/Admin/Inspections/Index");
        }


        
    }
}
