using ISO_Manager.Data;
using ISO_Manager.Models;
using ISO_Manager.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISO_Manager.Pages.Admin.User_infos
{
    public class CreateModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _context;

        
        public CreateModel(ISO_Manager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Models.Organization> UserOrganizations { get; set; } = default!;
        public IList<Models.Occupation> UserOccupations { get; set; } = default!;
        public IList<Models.Workplace> UserWorkplaces { get; set; } = default!;

        public long selectedUserId { get; set; }

        public IActionResult OnGetAsync(long user_id)
        {
            UserOrganizations = _context.Organizations.ToList();
            UserOccupations = _context.Occupations.ToList();
            UserWorkplaces = _context.Workplaces.ToList();
            selectedUserId = (long)user_id;
            return Page();
        }

        [BindProperty]
        public UserInfo User_info { get; set; } = default!;

        [BindProperty]
        public DateTime BirthDay { get; set; }

        [BindProperty]
        public DateTime EmploymentDate { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            UserOrganizations = _context.Organizations.ToList();
            UserOccupations = _context.Occupations.ToList();
            UserWorkplaces = _context.Workplaces.ToList();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            User_info.birthday = DateToMiladi.ToMiladi(BirthDay);
            User_info.employment_date= DateToMiladi.ToMiladi(EmploymentDate);

            _context.UserInfos.Add(User_info);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Admin/Users/Index");
        }
    }
}
