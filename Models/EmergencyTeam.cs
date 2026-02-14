using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class EmergencyTeam
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "وظیفه")]
        public string? duty { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;

        // relations


        [ForeignKey("User")]
        public string? user_id { get; set; }
        public User User { get; set; }


        [ForeignKey("Workplace")]
        public int? workplace_id { get; set; }
        public Workplace Workplace { get; set; }

        [ForeignKey("Duty")]
        public int? duty_id { get; set; }
        public Duty Duty { get; set; }
    }
}
