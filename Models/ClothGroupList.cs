using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class ClothGroupList
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "سایز کفش")]
        public string? shoes { get; set; }

        [Display(Name = "سایز لباس")]
        public string? boiler_suit { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;



        // relations

        [ForeignKey("User")]
        [Display(Name = "نام کاربر")]
        public string? user_id { get; set; }
        [Display(Name = "نام کاربر")]
        public User? User { get; set; }


        [ForeignKey("ClothGroup")]
        [Display(Name = "گروه کاربران")]
        public int? cloth_group_id { get; set; }
        [Display(Name = "گروه کاربران")]
        public ClothGroup? ClothGroup { get; set; }


    }
}
