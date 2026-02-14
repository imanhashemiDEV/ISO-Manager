using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Examination
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "تاریخ معاینه")]
        public int? examination_date { get; set; }

        [Display(Name = "نتیجه معاینه")]
        public string? examination_result { get; set; }

        [Display(Name = "توضیحات")]
        public string? description { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;


        // relations

        [ForeignKey("User")]
        [Display(Name = "نام و نام خانوادگی")]
        public string? user_id { get; set; }
        [Display(Name = "نام و نام خانوادگی")]
        public User? User { get; set; }

        [ForeignKey("Contractor")]
        [Display(Name = "نام شرکت پیمانکاری")]
        public int? contractor_id { get; set; }
        [Display(Name = "نام شرکت پیمانکاری")]
        public Contractor? Contractor { get; set; }
    }
}
