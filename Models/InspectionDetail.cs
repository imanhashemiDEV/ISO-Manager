using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class InspectionDetail
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "تاریخ بازرسی")]
        public DateTime? inspection_date { get; set; }

        [Display(Name = "متن بازرسی")]
        public string? text { get; set; }

        [Display(Name = "توضیحات")]
        public string? description { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;

        // relations


        [ForeignKey("Inspection")]
        public int? inspection_id { get; set; }
        public Inspection? Inspection { get; set; }

        [ForeignKey("InspectionText")]
        public int? text_id { get; set; }
        public InspectionText? InspectionText { get; set; }

        [ForeignKey("Workplace")]
        [Display(Name = "نام محل")]
        public int? workplace_id { get; set; }
        [Display(Name = "نام محل")]
        public Workplace? Workplace { get; set; }
    }
}
