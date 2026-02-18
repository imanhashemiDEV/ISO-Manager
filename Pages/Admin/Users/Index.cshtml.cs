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
        public readonly ApplicationDbContext _conText;

        public IndexModel(ApplicationDbContext conText)
        {
            _conText = conText;
        }

        public IList<User> Users { get; set; } = default!;

        [BindProperty]
        public string Search { get; set; }
        public async Task OnGet()
        {
            Users = await _conText.Users.OrderByDescending(c=>c.UpdatedAt).Take(10).ToListAsync();
        }

        public async Task OnPostAsync()
        {
            Users = await _conText.Users
                .Where(m => m.Mobile == Search || m.Name.Contains(Search) || m.RegisterCode == Search || m.NationalCode == Search)
                .ToListAsync();


        }
    }
}
