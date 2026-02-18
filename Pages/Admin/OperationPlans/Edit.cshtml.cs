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

namespace ISO_Manager.Pages.Admin.OperationPlans
{
    public class EditModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public EditModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
        }

        [BindProperty]
        public OperationPlan OperationPlan { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operationplan =  await _conText.OperationPlans.FirstOrDefaultAsync(m => m.Id == id);
            if (operationplan == null)
            {
                return NotFound();
            }
            OperationPlan = operationplan;
           ViewData["PurposeId"] = new SelectList(_conText.Purposes, "id", "id");
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

            _conText.Attach(OperationPlan).State = EntityState.Modified;

            try
            {
                await _conText.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OperationPlanExists(OperationPlan.Id))
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

        private bool OperationPlanExists(long id)
        {
            return _conText.OperationPlans.Any(e => e.Id == id);
        }
    }
}
