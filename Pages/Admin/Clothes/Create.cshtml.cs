using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ISO_Manager.Data;
using ISO_Manager.Models;
using ISO_Manager.Utilities;

namespace ISO_Manager.Pages.Admin.Clothes
{
    public class CreateModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbContext _conText;

        public CreateModel(ISO_Manager.Data.ApplicationDbContext conText)
        {
            _conText = conText;
        }

        public IActionResult OnGet()
        {
        ViewData["OrganizationId"] = new SelectList(_conText.Organizations, "id", "id");
        ViewData["users"] = _conText.Users.Where(m=>m.EmploymentType == "rasmi" || m.EmploymentType=="gharardadi").ToList();
            return Page();
        }

        [BindProperty]
        public Cloth Cloth { get; set; } = default!;

        [BindProperty]
        public DateTime ReceivedDate { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Cloth.ReceiveDate = DateToMiladi.ToMiladi(ReceivedDate);

            _conText.Clothes.Add(Cloth);
            await _conText.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
