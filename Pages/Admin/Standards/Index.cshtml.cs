using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.Standards
{
    public class IndexModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public IndexModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Standard> Standard { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Standard = await _context.Standards.ToListAsync();
        }
    }
}
