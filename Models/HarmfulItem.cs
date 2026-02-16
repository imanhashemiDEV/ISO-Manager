using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class HarmfulItem
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان عامل زیان آور")]
        public string? Title { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        //relations

        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }


        [ForeignKey("HarmfulFactor")]
        public int? HarmfulFactorId { get; set; }
        public virtual HarmfulFactor? HarmfulFactor { get; set; }



    }
}
