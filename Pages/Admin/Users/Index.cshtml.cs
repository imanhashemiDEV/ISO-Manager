using ISO_Manager.Data;
using ISO_Manager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ISO_Manager.Pages.Admin.Users
{
    public class IndexModel : PageModel
    {
        public readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<User> Users { get; set; } = default!;

        [BindProperty]
        public string Search { get; set; }
        public async Task OnGet()
        {
            Users = await _context.Users.OrderByDescending(c=>c.updated_at).Take(10).ToListAsync();
        }

        public async Task OnPostAsync()
        {
            Users = await _context.Users
                .Where(m => m.mobile == Search || m.name.Contains(Search) || m.register_code == Search || m.national_code == Search)
                .ToListAsync();


        }
    }
}
