using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class UserPermit
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "تاریخ انقضا")]
        public DateTime expire_date { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;


        // relations

        [ForeignKey("User")]
        [Display(Name = "دریافت کننده")]
        public string? user_id { get; set; }
        [Display(Name = "دریافت کننده")]
        public User? User { get; set; }
    }
}
