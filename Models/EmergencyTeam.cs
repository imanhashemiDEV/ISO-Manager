using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class EmergencyTeam
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "وظیفه")]
        public string? DutyTitle { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // relations


        [ForeignKey("User")]
        public string? UserId { get; set; }
        public virtual User? User { get; set; }


        [ForeignKey("WorkPlace")]
        public int? WorkPlaceId { get; set; }
        public virtual WorkPlace? WorkPlace { get; set; }

        [ForeignKey("Duty")]
        public int? DutyId { get; set; }
        public virtual Duty? Duty { get; set; }


        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }

    }
}
