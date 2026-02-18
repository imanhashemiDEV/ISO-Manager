using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class UserPermit
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "تاریخ انقضا")]
        public DateTime ExpireDate { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        // relations

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
