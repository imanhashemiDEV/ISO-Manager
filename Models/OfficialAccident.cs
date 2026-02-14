using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class OfficialAccident
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "شماره حادثه")]
        public string? accident_number { get; set; }

        [Display(Name = "تاریخ حادثه")]
        public DateTime? accident_date { get; set; }

        [Display(Name = "ساعت حادثه")]
        public TimeOnly? accident_hour { get; set; }

        [Display(Name = "وضعیت تاهل")]
        public string? marriage { get; set; }

        [Display(Name = "محل حادثه")]
        public string? accident_place { get; set; }

        [Display(Name = "فعالیت حین حادثه")]
        public string? activity_in_accident { get; set; }

        [Display(Name = "علت مستقیم حادثه")]
        public string? direct_accident_causes { get; set; }

        [Display(Name = "عمل ناایمن")]
        public string? unsafe_action_causes { get; set; }

        [Display(Name = "شرایط ناایمن")]
        public string? unsafe_condition_causes { get; set; }

        [Display(Name = "شرح حادثه")]
        public string? accident_description { get; set; }

        [Display(Name = "رئیس اداره")]
        public string? accident_boss { get; set; }

        [Display(Name = "نظریه پزشک")]
        public string? doctor_description { get; set; }

        [Display(Name = "تاریخ آزمایش")]
        public DateTime? examination_date { get; set; }

        [Display(Name = "نظریه HSE")]
        public string? hse_description { get; set; }

        [Display(Name = "آیا مقصر بوده؟")]
        public Int16? is_guilty { get; set; }

        [Display(Name = "عوارض ناشی از حادثه")]
        public string? accident_consequence { get; set; }

        [Display(Name = "پیامد حادثه")]
        public string? accident_complication { get; set; }

        [Display(Name = "عضو آسیب دیده")]
        public string? accident_injured_part { get; set; }

        [Display(Name = "رئیس HSE")]
        public string? hse_boss { get; set; }

        [Display(Name = "اسکن گزارش")]
        public string? scan { get; set; }

        [Display(Name = "روزهای از دست رفته")]
        public int? lost_days { get; set; }

        [Display(Name = "تاریخ دریافت گزارش")]
        public DateTime? receive_report_date { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;

        // relations


        [ForeignKey("User")]
        [Display(Name = "نام و نام خانوادگی")]
        public string? user_id { get; set; }
        [Display(Name = "نام و نام خانوادگی")]
        public User? User { get; set; }

    }
}
