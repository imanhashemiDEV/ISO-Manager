using System.ComponentModel.DataAnnotations;

namespace ISO_Manager.Models
{
    public class Contractor
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان پیمان")]
        public string? title { get; set; }

        [Display(Name = "شرکت")]
        public string? company { get; set; }

        [Display(Name = "کارفرما")]
        public string? employer { get; set; }

        [Display(Name = "موبایل کارفرما")]
        public string? employer_mobile { get; set; }

        [Display(Name = "پیمانکار")]
        public string? manager { get; set; }

        [Display(Name = "موبایل پیمانکار")]
        public string? manager_mobile { get; set; }

        [Display(Name = "نماینده پیمانکار")]
        public string? manager_agent { get; set; }

        [Display(Name = "موبایل نماینده پیمانکار")]
        public string? manager_agent_mobile { get; set; }

        [Display(Name = "نماینده HSE")]
        public string? hse_agent { get; set; }

        [Display(Name = "نماینده HSE موبایل")]
        public string? hse_agent_mobile { get; set; }

        [Display(Name = "تعداد پرسنل")]
        public int? personnel_count { get; set; }

        [Display(Name = "شماره قرارداد")]
        public string? contract_number { get; set; }

        [Display(Name = "تاریخ شروع")]
        public DateTime start_date { get; set; }=DateTime.Now;

        [Display(Name = "تاریخ پایان")]
        public DateTime end_date { get; set; }= DateTime.Now;

        [Display(Name = "توضیحات")]
        public string? description { get; set; }

        [Display(Name = "وضعیت")]
        public string? status { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;

    }
}
