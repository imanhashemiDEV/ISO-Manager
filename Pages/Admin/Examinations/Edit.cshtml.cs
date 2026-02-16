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

namespace ISO_Manager.Pages.Admin.Examinations
{
    public class EditModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbConText _conText;

        public EditModel(ISO_Manager.Data.ApplicationDbConText conText)
        {
            _conText = conText;
        }

        [BindProperty]
        public Examination Examination { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var examination =  await _conText.Examinations.FirstOrDefaultAsync(m => m.Id == id);
            if (examination == null)
            {
                return NotFound();
            }
            Examination = examination;
           ViewData["ContractorId"] = new SelectList(_conText.Contractors, "id", "Company");
           ViewData["UserId"] = new SelectList(_conText.Users, "id", "name");
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

            _conText.Attach(Examination).State = EntityState.Modified;

            try
            {
                await _conText.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExaminationExists(Examination.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            if (Examination.ContractorId != null)
            {
                return RedirectToPage("./Contractor" , new {ContractorId = Examination.ContractorId.ToString()});
            }

            return RedirectToPage("./Index");
        }

        private bool ExaminationExists(long id)
        {
            return _conText.Examinations.Any(e => e.Id == id);
        }
    }
}
