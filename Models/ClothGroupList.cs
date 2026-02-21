using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class ClothGroupList
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "سایز کفش الزامی است")]
        [Display(Name = "سایز کفش")]
        public int? Shoes { get; set; }

        [Required(ErrorMessage = "سایز لباس الزامی است")]
        [Display(Name = "سایز لباس")]
        public int? BoilerSuit { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;



        // relations

        [Required(ErrorMessage = "نام کاربر الزامی است")]
        [ForeignKey("User")]
        [Display(Name = "نام کاربر")]
        public string? UserId { get; set; }
        [Display(Name = "نام کاربر")]
        public virtual User? User { get; set; }


        [Required(ErrorMessage = "گروه کارکنان الزامی است")]
        [ForeignKey("ClothGroup")]
        [Display(Name = "گروه کارکنان")]
        public int? ClothGroupId { get; set; }
        [Display(Name = "گروه کارکنان")]
        public virtual ClothGroup? ClothGroup { get; set; }


        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }



    }
}
