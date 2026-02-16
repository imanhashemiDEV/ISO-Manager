using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISO_Manager.Data;
using ISO_Manager.Models;

namespace ISO_Manager.Pages.Admin.Messages
{
    public class IndexModel : PageModel
    {
        private readonly ISO_Manager.Data.ApplicationDbConText _conText;

        public IndexModel(ISO_Manager.Data.ApplicationDbConText conText)
        {
            _conText = conText;
        }

        public IList<Message> Message { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Message = await _conText.Messages
                .Include(m => m.Receiver)
                .Include(m => m.Sender).ToListAsync();
        }
    }
}
