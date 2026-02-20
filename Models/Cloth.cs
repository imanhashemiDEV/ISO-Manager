using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Cloth
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="نوع لباس الزامی است")]
        [Display(Name = "نوع لباس")]
        public string? ClothType { get; set; }

        [Required(ErrorMessage = "تاریخ تحویل الزامی است")]
        [Display(Name = "تاریخ تحویل")]
        public DateTime ReceiveDate { get; set; }

        [Required(ErrorMessage = "نوع دریافت الزامی است")]
        [Display(Name = "نوع دریافت")]
        public string? ReceiveType { get; set; }

        [Display(Name = "سایز")]
        public int? Size { get; set; }

        [Display(Name = "توضیحات")]
        public string? Description { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        // relations

        [Required(ErrorMessage = "نام کاربر الزامی است")]
        [ForeignKey("User")]
        [Display(Name = "دریافت کننده")]
        public string? UserId { get; set; }
        [Display(Name = "دریافت کننده")]
        public virtual User? User { get; set; }



        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }

    }
}
