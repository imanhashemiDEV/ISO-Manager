using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class OperationPlan
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان")]
        public string? title { get; set; }

        [Display(Name = "تخمین")]
        public int? estimate { get; set; }

        [Display(Name = "انجام")]
        public int? done { get; set; }

        [Display(Name = "واحد")]
        public string? unit { get; set; }

        [Display(Name = "درصد پلن")]
        public decimal? plan_percent { get; set; }

        [Display(Name = "درصد واقعی")]
        public decimal? realization_percent { get; set; }

        [Display(Name = "درصد ")]
        public decimal? plan_realization_percent { get; set; }

        [Display(Name = "درصد قابل پذیرش")]
        public decimal? accept_percent { get; set; }

        [Display(Name = "وضعیت")]
        public string? status { get; set; }

        [Display(Name = "توضیحات")]
        public string? description { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;

        // relations


        [ForeignKey("Purpose")]
        public int? purpose_id { get; set; }
        public Purpose Purpose { get; set; }

    }
}
