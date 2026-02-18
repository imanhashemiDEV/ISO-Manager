using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Process
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "شماره فرایند")]
        public string? ProcessNumber { get; set; }

        [Display(Name = "شماره بازنگری")]
        public string? ProcessReviewNumber { get; set; }

        [Display(Name = "تاریخ ویرایش")]
        public DateTime ProcessEditDate { get; set; } = DateTime.Now;

        [Display(Name = "عنوان فرایند")]
        public string? ProcessTitle { get; set; }

        [Display(Name = "اهداف فرایند")]
        public string? ProcessPurpose { get; set; }

        [Display(Name = "مالک فرایند")]
        public string? ProcessOwner { get; set; }

        [Display(Name = "منابع")]
        public string? ProcessResources { get; set; }

        [Display(Name = "گروه فرایندی")]
        public string? ProcessGroup { get; set; }

        [Display(Name = "الزامات ذینفعان")]
        public string? ProcessRequirement { get; set; }

        [Display(Name = "ورودی")]
        public string? ProcessInputs { get; set; }

        [Display(Name = "تامین کننده")]
        public string? ProcessProviders { get; set; }

        [Display(Name = "فعالیت ها")]
        public string? ProcessActitvities { get; set; }

        [Display(Name = "مسئول اجرا")]
        public string? ProcessResponsible { get; set; }

        [Display(Name = "اسناد")]
        public string? ProcessDocuments { get; set; }

        [Display(Name = "خروجی")]
        public string? ProcessExport { get; set; }

        [Display(Name = "ذینفعان")]
        public string? ProcessIntrested { get; set; }

        [Display(Name = "سال")]
        public string? Year { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        // relations

        [ForeignKey("Office")]
        public int? OfficeId { get; set; }
        public virtual Office? Office { get; set; }

        [ForeignKey("Organization")]
        public int? OrganizationId { get; set; }
        public virtual Organization? Organization { get; set; }

    }
}
