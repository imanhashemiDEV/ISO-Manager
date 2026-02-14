using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Maneuver
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان")]
        public string? title { get; set; }

        [Display(Name = "محل")]
        public string? place { get; set; }

        [Display(Name = "سال")]
        public int? year { get; set; }

        [Display(Name = "نوع مانور")]
        public string? type { get; set; }

        [Display(Name = "سطح مانور")]
        public string? level { get; set; }

        [Display(Name = "وضعیت")]
        public string? status { get; set; }

        [Display(Name = "زمان اجرا")]
        public string? act_time { get; set; }

        [Display(Name = "تجهیزات")]
        public string? equipment { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;


    }
}
