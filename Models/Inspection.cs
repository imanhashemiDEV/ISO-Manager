using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Inspection
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "تاریخ بازرسی")]
        public DateTime InspectionDate { get; set; }

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


        [ForeignKey("WorkPlace")]
        [Display(Name = "نام محل کار")]
        public int? WorkPlaceId { get; set; }
        [Display(Name = "نام محل کار")]
        public virtual WorkPlace? WorkPlace { get; set; }


        [ForeignKey("InspectionPlace")]
        [Display(Name = "نام گروه بازرسی")]
        public int? InspectionPlaceId { get; set; }
        [Display(Name = "نام گروه بازرسی")]
        public virtual InspectionPlace? InspectionPlace { get; set; }


        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }

        public virtual List<InspectionDetail>? InspectionDetails { get; set; }

    }
}
