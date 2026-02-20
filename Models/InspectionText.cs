using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Inspectiontext
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "متن سوال بازرسی")]
        public string? text { get; set; }

        [Display(Name = "مرتبه سوال بازرسی")]
        public int? Step { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;


        // relations

        [ForeignKey("InspectionPlace")]
        public int? InspectionPlaceId { get; set; }
        public virtual InspectionPlace? InspectionPlace { get; set; }


        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }

    }
}
