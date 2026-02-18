using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.ProcessPlans
{
    public class EditModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public EditModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
        }

        [BindProperty]
        public ProcessPlan ProcessPlan { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var processplan =  await _conText.ProcessPlans.FirstOrDefaultAsync(m => m.Id == id);
            if (processplan == null)
            {
                return NotFound();
            }
            ProcessPlan = processplan;
           ViewData["process_id"] = new SelectList(_conText.Processes, "id", "id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _conText.Attach(ProcessPlan).State = EntityState.Modified;

            try
            {
                await _conText.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProcessPlanExists(ProcessPlan.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProcessPlanExists(long id)
        {
            return _conText.ProcessPlans.Any(e => e.Id == id);
        }
    }
}
