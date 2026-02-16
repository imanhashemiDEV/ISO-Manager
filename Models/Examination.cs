using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Examination
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "تاریخ معاینه")]
        public int? ExaminationDate { get; set; }

        [Display(Name = "نتیجه معاینه")]
        public string? ExaminationResult { get; set; }

        [Display(Name = "توضیحات")]
        public string? Description { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        // relations

        [ForeignKey("User")]
        [Display(Name = "نام و نام خانوادگی")]
        public string? UserId { get; set; }
        [Display(Name = "نام و نام خانوادگی")]
        public virtual User? User { get; set; }

        [ForeignKey("Contractor")]
        [Display(Name = "نام شرکت پیمانکاری")]
        public int? ContractorId { get; set; }
        [Display(Name = "نام شرکت پیمانکاری")]
        public virtual Contractor? Contractor { get; set; }


        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }

    }
}
