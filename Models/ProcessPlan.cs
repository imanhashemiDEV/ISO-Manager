using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class ProcessPlan
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان")]
        public string? Title { get; set; }

        [Display(Name = "درصد")]
        public decimal? AcceptPercent { get; set; }

        [Display(Name = "درصد")]
        public decimal? PlanPercent { get; set; }

        [Display(Name = "وضعیت")]
        public string? Status { get; set; }

        [Display(Name = "انحراف")]
        public string? Deviation { get; set; }

        [Display(Name = "تقاضا")]
        public string? Requests { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        // relations


        [ForeignKey("Process")]
        public int? ProcessId { get; set; }
        public virtual Process? Process { get; set; }


        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }

    }
}
