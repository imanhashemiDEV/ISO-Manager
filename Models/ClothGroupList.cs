using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class ClothGroupList
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "سایز کفش")]
        public string? Shoes { get; set; }

        [Display(Name = "سایز لباس")]
        public string? BoilerSuit { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;



        // relations

        [ForeignKey("User")]
        [Display(Name = "نام کاربر")]
        public string? UserId { get; set; }
        [Display(Name = "نام کاربر")]
        public virtual User? User { get; set; }


        [ForeignKey("ClothGroup")]
        [Display(Name = "گروه کاربران")]
        public int? ClothGroupId { get; set; }
        [Display(Name = "گروه کاربران")]
        public virtual ClothGroup? ClothGroup { get; set; }


        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }



    }
}
