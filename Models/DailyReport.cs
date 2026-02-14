using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class DailyReport
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "نوع تجهیز")]
        public string? type { get; set; }

        [Display(Name = "نام تجهیز")]
        public string? unit { get; set; }

        [Display(Name = "محل قرارگیری")]
        public string? location { get; set; }

        [Display(Name = "وضعیت")]
        public string? status { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;

        // relations


        
        [ForeignKey("RigBoss")]
        [Display(Name = "رئیس دستگاه")]
        public string? rig_boss_id { get; set; }
        [Display(Name = "رئیس دستگاه")]
        public User? RigBoss { get; set; }


        [ForeignKey("CampBoss")]
        [Display(Name = "سرپرست اردوگاه")]
        public string? camp_boss_id { get; set; }
        [Display(Name = "سرپرست اردوگاه")]
        public User? CampBoss { get; set; }


        [ForeignKey("Doctor")]
        [Display(Name = "پزشک")]
        public string? doctor_id { get; set; }
        [Display(Name = "پزشک")]
        public User? Doctor { get; set; }


    }
}
