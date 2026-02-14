using System.Globalization;
using ISO_Manager.Data;
using ISO_Manager.Models;
using ISO_Manager.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ISO_Manager.Pages.Admin
{
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
           //// var user = _context.UserInfos.First(m => Equals(m.user_id , id));
            // var B = user.birthday;
            // var diff = DateTime.Now - B;
            // Age = ((diff.Days%365)/30)-1;
            //Age = (12 - B.Month)+1;
            //Age = (30 - B.Day)+2;


            PersianCalendar pc = new PersianCalendar();
            DateTime thisDate = DateTime.Now;
            int shamsi_year = pc.GetYear(thisDate);
            YearStartDate = pc.ToDateTime(shamsi_year, 01, 01, 00, 00, 0, 0); 
            YearEndDate = pc.ToDateTime(shamsi_year, 12, 29, 11, 59, 0, 0); 

            //var gregorianCalendar = new GregorianCalendar();
            //var year = gregorianCalendar.GetYear(DateTime.Now).ToString();
            //YearStartDate = DateTime.Parse($"{year}/01/01");

            // Users
            var users = _context.Users;
            RasmiUserCount = users.Where(m=>m.EmploymentType == "rasmi").Count();
            GharardadiUserCount = users.Where(m=>m.EmploymentType == "gharardadi").Count();
            PeymankariUserCount = users.Where(m=>m.EmploymentType == "peymankari").Count();


            // Accidents
            var OfficialAccidents = _context.OfficialAccidents;
            RasmiAccidentCount = OfficialAccidents.Where(m=>m.accident_complication== "???? ?? ??? ?????")
                .Count(m => m.accident_date >= YearStartDate && m.accident_date <= YearEndDate);
            var RasmiLostDays = OfficialAccidents
                .Where(m => m.accident_complication == "???? ?? ??? ?????" && m.accident_date >= YearStartDate && m.accident_date <= YearEndDate)
                .Sum(m => m.lost_days);

            var ContractorAccidents = _context.ContractorAccidents;
            PeymankariAccidentCount = ContractorAccidents
                .Where(m => m.accident_complication == "???? ?? ??? ?????")
                .Count(m => m.accident_date >= YearStartDate && m.accident_date <= YearEndDate);
            var PeymankariLostDays = ContractorAccidents.Where(m => m.accident_complication == "???? ?? ??? ?????" && m.accident_date >= YearStartDate && m.accident_date <= YearEndDate)
                .Sum(m => m.lost_days);

            LostAccidentDays = (int)(RasmiLostDays + PeymankariLostDays);

            // Calibration
            var Calibration = _context.Calibrations;
            ActiveGasDetector = Calibration.Count(m => m.status=="active");
            InProgressGasDetector = Calibration.Count(m => m.status== "in-calibration");
            ExpiredGasDetector = Calibration.Count(m => m.status== "wasted");

            //Contractors
            var Contractors = _context.Contractors;
            ActiveContractor = Contractors.Where(m=>m.end_date > DateTime.Now).Count(m => m.status == "active");
            ExpiredContractor = Contractors.Where(m=>m.end_date < DateTime.Now).Count(m => m.status == "active");


            DailyReport = await _context.DailyReports
                .Include(d => d.CampBoss)
                .Include(d => d.Doctor)
                .Include(d => d.RigBoss)
                .Where(m=>m.type=="rig")
                .ToListAsync();
        }
    }
}
