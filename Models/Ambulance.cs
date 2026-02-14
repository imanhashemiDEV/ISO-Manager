using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Ambulance
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "وضعیت")]
        public string? status { get; set; }

        [Display(Name = "پیمانکار")]
        public string? owner { get; set; }

        [Display(Name = "مدل")]
        public string? car_model { get; set; }

        [Display(Name = "سال ساخت")]
        public string? car_year { get; set; }

        [Display(Name = "نوع آمبولانس")]
        public string? type { get; set; }

        [Display(Name = "مالکیت")]
        public string? owner_status { get; set; }

        [Display(Name = "شماره استیجاری")]
        public string? rental_number { get; set; }

        [Display(Name = "پلاک")]
        public string? car_tag { get; set; }

        [Display(Name = "توضیحات")]
        public string? description { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;

        // relations


        [ForeignKey("User")]
        [Display(Name = "نام و نام خانوادگی راننده")]
        public string? user_id { get; set; }
        [Display(Name = "نام و نام خانوادگی راننده")]
        public User? User { get; set; }


        [ForeignKey("Workplace")]
        [Display(Name = "نام محل")]
        public int? workplace_id { get; set; }
        [Display(Name = "نام محل")]
        public Workplace? Workplace { get; set; }

    }
}
