using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.ProcessPlans
{
    public class CreateModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public CreateModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int process_id)
        {
            ViewData["ProcessId"] = process_id;
            return Page();
        }

        [BindProperty]
        public ProcessPlan ProcessPlan { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ProcessPlans.Add(ProcessPlan);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index", new {id = ProcessPlan.ProcessId });
        }
    }
}
