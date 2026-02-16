using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Permit
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "مکان")]
        public string? Place { get; set; }

        [Display(Name = "نوع پرمیت")]
        public string? PermitType { get; set; }

        [Display(Name = "نوع ضمیمه")]
        public string? PermitAttachmentType { get; set; }

        [Display(Name = "تاریخ پرمیت")]
        public DateTime? PermitDate { get; set; }

        [Display(Name = "شماره پرمیت")]
        public string? PermitNumber { get; set; }

        [Display(Name = "مدت زمان")]
        public string? Duration { get; set; }

        [Display(Name = "صاحب محل")]
        public string? Owner { get; set; }

        [Display(Name = "مسئول انجام")]
        public string? Responsible { get; set; }

        [Display(Name = "توضیحات")]
        public string? Description { get; set; }

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
