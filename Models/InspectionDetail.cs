using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class InspectionDetail
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "تاریخ بازرسی")]
        public DateTime? InspectionDate { get; set; }

        [Display(Name = "متن بازرسی")]
        public string? Text { get; set; }

        [Display(Name = "توضیحات")]
        public string? Description { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // relations


        [ForeignKey("Inspection")]
        public int? InspectionId { get; set; }
        public virtual Inspection? Inspection { get; set; }

        [ForeignKey("InspectionText")]
        public int? TextId { get; set; }
        public virtual InspectionText? InspectionText { get; set; }

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
