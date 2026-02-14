using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "تاریخ تولد")]
        public DateTime birthday { get; set; }

        [Display(Name = "تاریخ استخدام")]
        public DateTime employment_date { get; set; }

        [Display(Name = "مدرک تحصیلی")]
        public string? degree { get; set; }

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


        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? organization_id { get; set; }
        [Display(Name = "نام سازمان")]
        public Organization? Organization { get; set; }


        [ForeignKey("Occupation")]
        [Display(Name = "سمت")]
        public int? occupation_id { get; set; }
        [Display(Name = "سمت")]
        public Occupation? Occupation { get; set; }
        


        [ForeignKey("Workplace")]
        [Display(Name = "محل کار")]
        public int? workplace_id { get; set; }
        [Display(Name = "محل کار")]
        public Workplace? Workplace { get; set; }

    }
}
