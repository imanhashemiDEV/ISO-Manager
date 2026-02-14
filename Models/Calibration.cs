using System.ComponentModel.DataAnnotations;

namespace ISO_Manager.Models
{
    public class Calibration
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان")]
        public string? title { get; set; }

        [Display(Name = "شماره اموال")]
        public string? asset_number { get; set; }

        [Display(Name = "شماره سریال")]
        public string? serial_number { get; set; }

        [Display(Name = "صاحب")]
        public string? device_owner { get; set; }

        [Display(Name = "محل استفاده")]
        public string? device_user { get; set; }

        [Display(Name = "تاریخ تحویل")]
        public DateTime delivery_date { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ کالیبراسیون")]
        public DateTime start_calibration { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ انقضا")]
        public DateTime end_calibration { get; set; } = DateTime.Now;

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
