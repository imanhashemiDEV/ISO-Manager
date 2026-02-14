using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class OccupationHarmful
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "منبع")]
        public string? exposure_source { get; set; }

        [Display(Name = "روش")]
        public string? evaluation_method { get; set; }

        [Display(Name = "درصد تماس")]
        public string? exposure_rate { get; set; }

        [Display(Name = "مدت زمان تماس")]
        public string? exposure_duration { get; set; }

        [Display(Name = "محدودیت")]
        public string? exposure_limit { get; set; }

        [Display(Name = "وضعیت")]
        public string? status { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;




        [ForeignKey("Occupation")]
        public int? occupation_id { get; set; }
        public Occupation Occupation { get; set; }


        [ForeignKey("HarmfulFactor")]
        public int? harmful_factor_id { get; set; }
        public HarmfulFactor HarmfulFactor { get; set; }


        [ForeignKey("Workplace")]
        public int? harmful_item_id { get; set; }
        public HarmfulItem HarmfulItem { get; set; }

    }
}
