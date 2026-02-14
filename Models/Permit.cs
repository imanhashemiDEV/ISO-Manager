using System.ComponentModel.DataAnnotations;

namespace ISO_Manager.Models
{
    public class Permit
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "مکان")]
        public string? place { get; set; }

        [Display(Name = "نوع پرمیت")]
        public string? permit_type { get; set; }

        [Display(Name = "نوع ضمیمه")]
        public string? permit_attachment_type { get; set; }

        [Display(Name = "تاریخ پرمیت")]
        public DateTime? permit_date { get; set; }

        [Display(Name = "شماره پرمیت")]
        public string? permit_number { get; set; }

        [Display(Name = "مدت زمان")]
        public string? duration { get; set; }

        [Display(Name = "صاحب محل")]
        public string? owner { get; set; }

        [Display(Name = "مسئول انجام")]
        public string? responsible { get; set; }

        [Display(Name = "توضیحات")]
        public string? description { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;

    }
}
