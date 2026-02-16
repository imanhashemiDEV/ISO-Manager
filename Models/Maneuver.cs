using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Maneuver
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان")]
        public string? Title { get; set; }

        [Display(Name = "محل")]
        public string? Place { get; set; }

        [Display(Name = "سال")]
        public int? Year { get; set; }

        [Display(Name = "نوع مانور")]
        public string? Type { get; set; }

        [Display(Name = "سطح مانور")]
        public string? Level { get; set; }

        [Display(Name = "وضعیت")]
        public string? Status { get; set; }

        [Display(Name = "زمان اجرا")]
        public string? ActTime { get; set; }

        [Display(Name = "تجهیزات")]
        public string? Equipment { get; set; }

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
