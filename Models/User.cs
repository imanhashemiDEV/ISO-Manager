using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ISO_Manager.Models
{
    public class User : IdentityUser
    {
        [Display(Name = "نام و نام خانوادگی")]
        public string? Name { get; set; }

        [Display(Name = "موبایل")]
        public string? Mobile { get; set; }
        
        [Display(Name = "شماره پرسنلی")]
        public string? RegisterCode { get; set; }

        [Display(Name = "کد ملی")]
        public string? NationalCode { get; set; }
        
        [Display(Name = "عکس پروفایل")]
        public string? Image { get; set; }

        [Display(Name = "نوع استخدام")]
        public string? EmploymentType { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


      // relations

        public virtual UserInfo? UserInfos { get; set; }
    }
}
