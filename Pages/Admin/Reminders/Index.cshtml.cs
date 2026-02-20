using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.Reminders
{
    public class IndexModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public IndexModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Reminder> Reminder { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Reminder = await _context.Reminders
                //.Include(r => r.Organization)
                .Include(r => r.User).ToListAsync();
        }
    }
}
