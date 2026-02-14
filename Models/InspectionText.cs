using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class InspectionText
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "متن سوال بازرسی")]
        public string? text { get; set; }

        [Display(Name = "مرتبه سوال بازرسی")]
        public int? step { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime? updated_at { get; set; } = DateTime.Now;


        // relations

        [ForeignKey("InspectionPlace")]
        public int? inspection_place_id { get; set; }
        public InspectionPlace? InspectionPlace { get; set; }
    }
}
