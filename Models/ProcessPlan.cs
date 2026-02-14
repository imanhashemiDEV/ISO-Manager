using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class ProcessPlan
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان")]
        public string? title { get; set; }

        [Display(Name = "درصد")]
        public decimal? accept_percent { get; set; }

        [Display(Name = "درصد")]
        public decimal? plan_percent { get; set; }

        [Display(Name = "وضعیت")]
        public string? status { get; set; }

        [Display(Name = "انحراف")]
        public string? deviation { get; set; }

        [Display(Name = "تقاضا")]
        public string? requests { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;


        // relations


        [ForeignKey("Process")]
        public int? process_id { get; set; }
        public Process? Process { get; set; }
    }
}
