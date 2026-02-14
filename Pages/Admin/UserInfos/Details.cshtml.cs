using ISO_Manager.Data;
using ISO_Manager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISO_Manager.Pages.Admin.User_infos
{
    public class DetailsModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        public DetailsModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public UserInfo User_info { get; set; } = default!;
        public User SelectedUser { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? user_id)
        {

            if (user_id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FirstOrDefaultAsync(m => Equals(m.Id, user_id));
            SelectedUser = user;
            ViewData["occupation_id"] = new SelectList(_context.Occupations, "id", "title");
            var user_info = await _context.UserInfos
                .Include(r=>r.User)
                .Include(r=>r.Occupation)
                .FirstOrDefaultAsync(m => Equals(m.user_id , user_id));
            
            if (user_info is not null)
            {
                User_info = user_info;

                return Page();
            }

            return RedirectToPage("./Create", new {user_id = user_id});
        }


        [BindProperty]
        public User User { get; set; } = default!;
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(User).State = EntityState.Modified;

            await _context.SaveChangesAsync();
           

            return Page();
        }
    }
}
