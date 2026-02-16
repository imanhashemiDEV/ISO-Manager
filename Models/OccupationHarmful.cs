using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class OccupationHarmful
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "منبع")]
        public string? ExposureSource { get; set; }

        [Display(Name = "روش")]
        public string? EvaluationMethod { get; set; }

        [Display(Name = "درصد تماس")]
        public string? ExposureRate { get; set; }

        [Display(Name = "مدت زمان تماس")]
        public string? ExposureDuration { get; set; }

        [Display(Name = "محدودیت")]
        public string? ExposureLimit { get; set; }

        [Display(Name = "وضعیت")]
        public string? Status { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

       
        // relations

        [ForeignKey("Occupation")]
        public int? OccupationId { get; set; }
        public virtual Occupation? Occupation { get; set; }


        [ForeignKey("HarmfulFactor")]
        public int? HarmfulFactorId { get; set; }
        public virtual HarmfulFactor? HarmfulFactor { get; set; }


        [ForeignKey("WorkPlace")]
        public int? HarmfulItemId { get; set; }
        public virtual HarmfulItem? HarmfulItem { get; set; }


        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }


    }
}
