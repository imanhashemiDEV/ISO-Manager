using System.Globalization;
using ISO_Manager.Data;
using ISO_Manager.Models;
using ISO_Manager.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ISO_Manager.Pages.Admin
{
    //[Authorize]
    public class IndexModel : PageModel
    {

        public readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public int RasmiUserCount { get; set; } = 0;
        public int GharardadiUserCount { get; set; } = 0;
        public int PeymankariUserCount { get; set; } = 0;

        public int RasmiAccidentCount { get; set; } = 0;
        public int PeymankariAccidentCount { get; set; } = 0;
        public int LostAccidentDays { get; set; } = 0;

        public int ActiveGasDetector { get; set; } = 0;
        public int InProgressGasDetector { get; set; } = 0;
        public int ExpiredGasDetector { get; set; } = 0;

        public int ActiveContractor { get; set; } = 0;
        public int ExpiredContractor { get; set; } = 0;

        public int Age { get; set; }


        public DateTime YearStartDate { get; set; }
        public DateTime YearEndDate { get; set; }

        public IList<DailyReport> DailyReport { get; set; } = default!;

        public async Task OnGetAsync()
        {
           // long id = 30;
           //// var user = _context.UserInfos.First(m => Equals(m.UserId , id));
            // var B = user.Birthday;
            // var diff = DateTime.Now - B;
            // Age = ((diff.Days%365)/30)-1;
            //Age = (12 - B.Month)+1;
            //Age = (30 - B.Day)+2;


            PersianCalendar pc = new PersianCalendar();
            DateTime thisDate = DateTime.Now;
            int shamsi_Year = pc.GetYear(thisDate);
            YearStartDate = pc.ToDateTime(shamsi_Year, 01, 01, 00, 00, 0, 0); 
            YearEndDate = pc.ToDateTime(shamsi_Year, 12, 29, 11, 59, 0, 0); 

            //var gregorianCalendar = new GregorianCalendar();
            //var Year = gregorianCalendar.GetYear(DateTime.Now).ToString();
            //YearStartDate = DateTime.Parse($"{Year}/01/01");

            // Users
            var users = _context.Users;
            RasmiUserCount = users.Where(m=>m.EmploymentType == "rasmi").Count();
            GharardadiUserCount = users.Where(m=>m.EmploymentType == "gharardadi").Count();
            PeymankariUserCount = users.Where(m=>m.EmploymentType == "peymankari").Count();


            // Accidents
            var OfficialAccidents = _context.OfficialAccidents;
            RasmiAccidentCount = OfficialAccidents.Where(m=>m.AccidentComplication== "???? ?? ??? ?????")
                .Count(m => m.AccidentDate >= YearStartDate && m.AccidentDate <= YearEndDate);
            var RasmiLostDays = OfficialAccidents
                .Where(m => m.AccidentComplication == "???? ?? ??? ?????" && m.AccidentDate >= YearStartDate && m.AccidentDate <= YearEndDate)
                .Sum(m => m.LostDays);

            var ContractorAccidents = _context.ContractorAccidents;
            PeymankariAccidentCount = ContractorAccidents
                .Where(m => m.AccidentComplication == "???? ?? ??? ?????")
                .Count(m => m.AccidentDate >= YearStartDate && m.AccidentDate <= YearEndDate);
            var PeymankariLostDays = ContractorAccidents.Where(m => m.AccidentComplication == "???? ?? ??? ?????" && m.AccidentDate >= YearStartDate && m.AccidentDate <= YearEndDate)
                .Sum(m => m.LostDays);

            LostAccidentDays = (int)(RasmiLostDays + PeymankariLostDays);

            // Calibration
            var Calibration = _context.Calibrations;
            ActiveGasDetector = Calibration.Count(m => m.Status=="active");
            InProgressGasDetector = Calibration.Count(m => m.Status== "in-calibration");
            ExpiredGasDetector = Calibration.Count(m => m.Status== "wasted");

            //Contractors
            var Contractors = _context.Contractors;
            ActiveContractor = Contractors.Where(m=>m.EndDate > DateTime.Now).Count(m => m.Status == "active");
            ExpiredContractor = Contractors.Where(m=>m.EndDate < DateTime.Now).Count(m => m.Status == "active");


            DailyReport = await _context.DailyReports
                .Include(d => d.CampBoss)
                .Include(d => d.Doctor)
                .Include(d => d.RigBoss)
                .Where(m=>m.Type=="rig")
                .ToListAsync();
        }
    }
}
