using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class DailyReport
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "نوع تجهیز")]
        public string? Type { get; set; }

        [Display(Name = "نام تجهیز")]
        public string? Unit { get; set; }

        [Display(Name = "محل قرارگیری")]
        public string? Location { get; set; }

        [Display(Name = "وضعیت")]
        public string? Status { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        // relations

        [ForeignKey("RigBoss")]
        [Display(Name = "رئیس دستگاه")]
        public string? RigBossId { get; set; }
        [Display(Name = "رئیس دستگاه")]
        public virtual User? RigBoss { get; set; }


        [ForeignKey("CampBoss")]
        [Display(Name = "سرپرست اردوگاه")]
        public string? CampBossId { get; set; }
        [Display(Name = "سرپرست اردوگاه")]
        public virtual User? CampBoss { get; set; }


        [ForeignKey("Doctor")]
        [Display(Name = "پزشک")]
        public string? DoctorId { get; set; }
        [Display(Name = "پزشک")]
        public virtual User? Doctor { get; set; }


        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }



    }
}
