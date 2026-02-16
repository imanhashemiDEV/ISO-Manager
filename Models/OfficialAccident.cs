using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class OfficialAccident
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "شماره حادثه")]
        public string? AccidentNumber { get; set; }

        [Display(Name = "تاریخ حادثه")]
        public DateTime? AccidentDate { get; set; }

        [Display(Name = "ساعت حادثه")]
        public TimeOnly? AccidentHour { get; set; }

        [Display(Name = "وضعیت تاهل")]
        public string? Marriage { get; set; }

        [Display(Name = "محل حادثه")]
        public string? AccidentPlace { get; set; }

        [Display(Name = "فعالیت حین حادثه")]
        public string? ActivityInAccident { get; set; }

        [Display(Name = "علت مستقیم حادثه")]
        public string? DirectAccidentCauses { get; set; }

        [Display(Name = "عمل ناایمن")]
        public string? UnsafeActionCauses { get; set; }

        [Display(Name = "شرایط ناایمن")]
        public string? UnsafeConditionCauses { get; set; }

        [Display(Name = "شرح حادثه")]
        public string? AccidentDescription { get; set; }

        [Display(Name = "رئیس اداره")]
        public string? AccidentBoss { get; set; }

        [Display(Name = "نظریه پزشک")]
        public string? DoctorDescription { get; set; }

        [Display(Name = "تاریخ آزمایش")]
        public DateTime? ExaminationDate { get; set; }

        [Display(Name = "نظریه HSE")]
        public string? HseDescription { get; set; }

        [Display(Name = "آیا مقصر بوده؟")]
        public Int16? IsGuilty { get; set; }

        [Display(Name = "عوارض ناشی از حادثه")]
        public string? AccidentConsequence { get; set; }

        [Display(Name = "پیامد حادثه")]
        public string? AccidentComplication { get; set; }

        [Display(Name = "عضو آسیب دیده")]
        public string? AccidentInjuredPart { get; set; }

        [Display(Name = "رئیس HSE")]
        public string? HseBoss { get; set; }

        [Display(Name = "اسکن گزارش")]
        public string? Scan { get; set; }

        [Display(Name = "روزهای از دست رفته")]
        public int? LostDays { get; set; }

        [Display(Name = "تاریخ دریافت گزارش")]
        public DateTime? ReceiveReportDate { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // relations


        [ForeignKey("User")]
        [Display(Name = "نام و نام خانوادگی")]
        public string? UserId { get; set; }
        [Display(Name = "نام و نام خانوادگی")]
        public virtual User? User { get; set; }


        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }


    }
}
