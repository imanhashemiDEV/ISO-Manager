using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class HarmfulItem
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان عامل زیان آور")]
        public string? title { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;




        [ForeignKey("HarmfulFactor")]
        public int? harmful_factor_id { get; set; }
        public HarmfulFactor? HarmfulFactor { get; set; }
    }
}
