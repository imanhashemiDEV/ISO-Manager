using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.Examinations
{
    public class ContractorModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public ContractorModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Examination> Examination { get;set; } = default!;
        public long ContractorId { get; set; }

        public async Task OnGetAsync(long ContractorId , int pageId = 1)
        {

            ContractorId = ContractorId;

            var Take = 100;
            var skip = (pageId - 1) * Take;
            var ItemCount = _context.Examinations.Count(m => m.ContractorId == ContractorId);
            ViewData["ItemCount"] = ItemCount;
            ViewData["Take"] = Take;
            ViewData["pageId"] = pageId;

            if (ItemCount % Take == 0)
            {
                ViewData["PageCount"] = (ItemCount / Take);
            }
            else
            {
                ViewData["PageCount"] = (ItemCount / Take) + 1;
            }

            Examination = await _context.Examinations
                .Include(e => e.Contractor)
                .Include(e => e.User)
                .Where(m=>m.ContractorId == ContractorId)
                .OrderBy(m=>m.ExaminationResult)
                .Skip(skip).Take(Take)
                .ToListAsync();
        }
    }
}
