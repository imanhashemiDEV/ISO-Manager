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
        public IList<Inspectiontext> Inspectiontexts { get; set; } = default!;

        [BindProperty]
        public int selectedInspection { get; set; }

        public async Task<IActionResult> OnGetAsync(int inspectionId)
        {
            selectedInspection = inspectionId;

            var inspection = await _context.Inspections.FirstOrDefaultAsync(m => m.Id == inspectionId);
            var inspectiontexts = await _context.Inspectiontexts
                .Where(m=>m.InspectionPlaceId==inspection.InspectionPlaceId)
                .ToListAsync();

            if (inspection is not null)
            {
                Inspection = inspection;
                Inspectiontexts = inspectiontexts;

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
                
                var selected = await _context.Inspectiontexts.FindAsync(item);

                var detail = new InspectionDetail
                {
                    InspectionId = selectedInspection,
                    InspectionDate = inspection!.InspectionDate,
                    WorkPlaceId = inspection.WorkPlaceId,
                    textId = (int) item,
                    text = selected!.text,
                    //Description = InspectionDescription
                };

                _context.InspectionDetails.Add(detail);
                await _context.SaveChangesAsync();
            }


            return RedirectToPage("/Admin/Inspections/Index");
        }


        
    }
}
