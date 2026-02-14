using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Reminder
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان")]
        public string? title { get; set; }

        [Display(Name = "تاریخ یادآوری")]
        public DateTime? reminder_date { get; set; }

        [Display(Name = "وضعیت")]
        public string? status { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;


        // relations

        [ForeignKey("User")]
        public string? user_id { get; set; }
        public User? User { get; set; }


        //[ForeignKey("Organization")]
        //public long? organization_id { get; set; }
        //public Organization? Organization { get; set; }

    }
}
