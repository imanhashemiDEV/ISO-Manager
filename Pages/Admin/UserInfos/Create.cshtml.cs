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
        private readonly ISO_Manager.Data.ApplicationDbConText _conText;

        
        public CreateModel(ISO_Manager.Data.ApplicationDbConText conText)
        {
            _conText = conText;
        }

        public IList<Models.Organization> UserOrganizations { get; set; } = default!;
        public IList<Models.Occupation> UserOccupations { get; set; } = default!;
        public IList<Models.WorkPlace> UserWorkPlaces { get; set; } = default!;

        public long selectedUserId { get; set; }

        public IActionResult OnGetAsync(long UserId)
        {
            UserOrganizations = _conText.Organizations.ToList();
            UserOccupations = _conText.Occupations.ToList();
            UserWorkPlaces = _conText.WorkPlaces.ToList();
            selectedUserId = (long)UserId;
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

            UserOrganizations = _conText.Organizations.ToList();
            UserOccupations = _conText.Occupations.ToList();
            UserWorkPlaces = _conText.WorkPlaces.ToList();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            User_info.birthday = DateToMiladi.ToMiladi(BirthDay);
            User_info.employment_date= DateToMiladi.ToMiladi(EmploymentDate);

            _conText.UserInfos.Add(User_info);
            await _conText.SaveChangesAsync();

            return RedirectToPage("/Admin/Users/Index");
        }
    }
}
