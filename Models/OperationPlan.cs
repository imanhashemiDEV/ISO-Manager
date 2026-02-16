using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class OperationPlan
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان")]
        public string? Title { get; set; }

        [Display(Name = "تخمین")]
        public int? Estimate { get; set; }

        [Display(Name = "انجام")]
        public int? Done { get; set; }

        [Display(Name = "واحد")]
        public string? Unit { get; set; }

        [Display(Name = "درصد پلن")]
        public decimal? PlanPercent { get; set; }

        [Display(Name = "درصد واقعی")]
        public decimal? RealizationPercent { get; set; }

        [Display(Name = "درصد ")]
        public decimal? PlanRealizationPercent { get; set; }

        [Display(Name = "درصد قابل پذیرش")]
        public decimal? AcceptPercent { get; set; }

        [Display(Name = "وضعیت")]
        public string? Status { get; set; }

        [Display(Name = "توضیحات")]
        public string? Description { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        // relations

        [ForeignKey("Purpose")]
        [Display(Name = "هدف")]
        public int? PurposeId { get; set; }
        [Display(Name = "هدف")]
        public virtual Purpose? Purpose { get; set; }


        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }


    }
}
