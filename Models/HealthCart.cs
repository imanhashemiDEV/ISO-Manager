using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class HealthCart
    {


        [Key]
        public int Id { get; set; }

        [Display(Name = "تاریخ انقضا")]
        public DateTime EndDate { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        // relations

        [ForeignKey("User")]
        [Display(Name = "نام و نام خانوادگی ")]
        public string? UserId { get; set; }
        [Display(Name = "نام و نام خانوادگی ")]
        public virtual User? User { get; set; }


        [ForeignKey("WorkPlace")]
        [Display(Name = "نام محل")]
        public int? WorkPlaceId { get; set; }
        [Display(Name = "نام محل")]
        public virtual WorkPlace? WorkPlace { get; set; }

        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }


    }
}
