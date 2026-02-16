using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Contractor
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان پیمان")]
        public string? Title { get; set; }

        [Display(Name = "شرکت")]
        public string? Company { get; set; }

        [Display(Name = "کارفرما")]
        public string? Employer { get; set; }

        [Display(Name = "موبایل کارفرما")]
        public string? EmployerMobile { get; set; }

        [Display(Name = "پیمانکار")]
        public string? Manager { get; set; }

        [Display(Name = "موبایل پیمانکار")]
        public string? ManagerMobile { get; set; }

        [Display(Name = "نماینده پیمانکار")]
        public string? ManagerAgent { get; set; }

        [Display(Name = "موبایل نماینده پیمانکار")]
        public string? ManagerAgentMobile { get; set; }

        [Display(Name = "نماینده HSE")]
        public string? HseAgent { get; set; }

        [Display(Name = "نماینده HSE موبایل")]
        public string? HseAgentMobile { get; set; }

        [Display(Name = "تعداد پرسنل")]
        public int? PersonnelCount { get; set; }

        [Display(Name = "شماره قرارداد")]
        public string? ContractNumber { get; set; }

        [Display(Name = "تاریخ شروع")]
        public DateTime StartDate { get; set; }=DateTime.Now;

        [Display(Name = "تاریخ پایان")]
        public DateTime EndDate { get; set; }= DateTime.Now;

        [Display(Name = "توضیحات")]
        public string? Description { get; set; }

        [Display(Name = "وضعیت")]
        public string? Status { get; set; }

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
