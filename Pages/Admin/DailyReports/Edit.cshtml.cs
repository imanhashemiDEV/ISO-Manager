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

namespace ISO_Manager.Pages.Admin.DailyReports
{
    public class EditModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public EditModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DailyReport DailyReport { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dailyreport =  await _context.DailyReports.FirstOrDefaultAsync(m => m.Id == id);
            if (dailyreport == null)
            {
                return NotFound();
            }
            DailyReport = dailyreport;
           ViewData["CampBossId"] = new SelectList(_context.Users, "id", "name");
           ViewData["DoctorId"] = new SelectList(_context.Users, "id", "name");
           ViewData["RigBossId"] = new SelectList(_context.Users, "id", "name");
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

            _context.Attach(DailyReport).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DailyReportExists(DailyReport.Id))
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

        private bool DailyReportExists(long id)
        {
            return _context.DailyReports.Any(e => e.Id == id);
        }
    }
}
