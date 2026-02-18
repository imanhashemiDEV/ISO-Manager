using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "تاریخ تولد")]
        public DateTime Birthday { get; set; }

        [Display(Name = "تاریخ استخدام")]
        public DateTime EmploymentDate { get; set; }

        [Display(Name = "مدرک تحصیلی")]
        public string? Degree { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        // relations

        [ForeignKey("User")]
        [Display(Name = "نام و نام خانوادگی")]
        public string? UserId { get; set; }
        [Display(Name = "نام و نام خانوادگی")]
        public virtual User? User { get; set; }


        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }


        [ForeignKey("Occupation")]
        [Display(Name = "سمت")]
        public int? OccupationId { get; set; }
        [Display(Name = "سمت")]
        public virtual Occupation? Occupation { get; set; }
        

        [ForeignKey("WorkPlace")]
        [Display(Name = "محل کار")]
        public int? WorkPlaceId { get; set; }
        [Display(Name = "محل کار")]
        public virtual WorkPlace? WorkPlace { get; set; }

    }
}
