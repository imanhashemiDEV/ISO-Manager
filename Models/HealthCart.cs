using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class HealthCart
    {


        [Key]
        public int Id { get; set; }

        [Display(Name = "تاریخ انقضا")]
        public DateTime end_date { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;


        // relations

        [ForeignKey("User")]
        [Display(Name = "نام و نام خانوادگی ")]
        public string? user_id { get; set; }
        [Display(Name = "نام و نام خانوادگی ")]
        public User? User { get; set; }


        [ForeignKey("Workplace")]
        [Display(Name = "نام محل")]
        public int? workplace_id { get; set; }
        [Display(Name = "نام محل")]
        public Workplace? Workplace { get; set; }

    }
}
