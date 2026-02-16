using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Ambulance
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "وضعیت")]
        public string? Status { get; set; }

        [Display(Name = "پیمانکار")]
        public string? Owner { get; set; }

        [Display(Name = "مدل")]
        public string? CarModel { get; set; }

        [Display(Name = "سال ساخت")]
        public string? CarYear { get; set; }

        [Display(Name = "نوع آمبولانس")]
        public string? Type { get; set; }

        [Display(Name = "مالکیت")]
        public string? OwnerStatus { get; set; }

        [Display(Name = "شماره استیجاری")]
        public string? RentalNumber { get; set; }

        [Display(Name = "پلاک")]
        public string? CarTag { get; set; }

        [Display(Name = "توضیحات")]
        public string? Description { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // relations


        [ForeignKey("User")]
        [Display(Name = "نام و نام خانوادگی راننده")]
        public string? UserId { get; set; }
        [Display(Name = "نام و نام خانوادگی راننده")]
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
