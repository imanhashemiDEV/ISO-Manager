using System.ComponentModel.DataAnnotations;

namespace ISO_Manager.Models
{
    public class LegalRequirement
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان  مقررات")]
        public string? regulation_title { get; set; }

        [Display(Name = "سازمان")]
        public string? regulation_organization { get; set; }

        [Display(Name = "تاریخ انتشار")]
        public string regulation_date { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;
    }
}
