using System.ComponentModel.DataAnnotations;

namespace ISO_Manager.Models
{
    public class Asset
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان  فارسی")]
        public string? title { get; set; }

        [Display(Name = "عنوان انگلیسی")]
        public string? e_title { get; set; }

        [Display(Name = "بازرس")]
        public string? inspector { get; set; }

        [Display(Name = "شماره اموال")]
        public string? asset_number { get; set; }

        [Display(Name = "شماره سریال")]
        public string? serial_number { get; set; }

        [Display(Name = "محل استفاده")]
        public string? device_user { get; set; }

        [Display(Name = "توضیحات")]
        public string? description { get; set; }

        [Display(Name = "وضعیت")]
        public string? status { get; set; }

        [Display(Name = "تاریخ بازرسی")]
        public DateTime inspection_date { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;


    }
}
