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

namespace ISO_Manager.Pages.Admin.Users
{
    public class EditModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public EditModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
        }

        [BindProperty]
        public User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {

            var user =  await _conText.Users.FirstOrDefaultAsync(m => Equals(m.Id , id));
            if (user == null)
            {
                return NotFound();
            }
            User = user;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _conText.Attach(User).State = EntityState.Modified;

            await _conText.SaveChangesAsync();
        

            return RedirectToPage("./Index");
        }

        private bool UserExists(string id)
        {
            return _conText.Users.Any(e => Equals(e.Id == id));
        }
    }
}
