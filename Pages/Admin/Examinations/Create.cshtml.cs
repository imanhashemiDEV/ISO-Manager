using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.Examinations
{
    public class CreateModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public CreateModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public long ContractorId { get; set; }

        public IActionResult OnGet(long? ContractorId)
        {
            ContractorId = (long)ContractorId;
            ViewData["ContractorId"] = new SelectList(_context.Contractors, "id", "Company");
        ViewData["UserId"] = new SelectList(_context.Users, "id", "name");
            return Page();
        }

        [BindProperty]
        public Examination Examination { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Examinations.Add(Examination);
            await _context.SaveChangesAsync();

            if (Examination.ContractorId != null)
            {
                return RedirectToPage("./Contractor", new { ContractorId = Examination.ContractorId.ToString() });
            }

            return RedirectToPage("./Index");
        }
    }
}
