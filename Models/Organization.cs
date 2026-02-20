using System.ComponentModel.DataAnnotations;

namespace ISO_Manager.Models
{
    public class Organization
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="نام سازمان الزامی است")]
        [Display(Name = "عنوان سازمان")]
        public string? Title { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
