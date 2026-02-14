using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ISO_Manager.Pages
{
    public class LoginModel : PageModel
    {
        public async Task<IActionResult> OnPostAsync()
        {
            return RedirectToPage("./Admin/Index");
        }
    }
}
