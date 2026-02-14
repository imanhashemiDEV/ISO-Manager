using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Cloth
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "نوع لباس")]
        public string? cloth_type { get; set; }

        [Display(Name = "تاریخ تحویل")]
        public DateTime receive_date { get; set; }

        [Display(Name = "نوع دریافت")]
        public string? receive_type { get; set; }

        [Display(Name = "سایز")]
        public int? size { get; set; }

        [Display(Name = "توضیحات")]
        public string? description { get; set; }

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


        //[ForeignKey("Organization")]
        //public long? organization_id { get; set; }
        //public Organization? Organization { get; set; }

    }
}
