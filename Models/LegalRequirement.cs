using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class LegalRequirement
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان  مقررات")]
        public string? RegulationTitle { get; set; }

        [Display(Name = "سازمان")]
        public string? RegulationOrganization { get; set; }

        [Display(Name = "تاریخ انتشار")]
        public string? RegulationDate { get; set; }

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

    }
}
