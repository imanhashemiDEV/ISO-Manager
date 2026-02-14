using System.ComponentModel.DataAnnotations;

namespace ISO_Manager.Models
{
    public class Cartable
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "موضوع")]
        public string? title { get; set; }

        [Display(Name = "توضیحات")]
        public string? description { get; set; }

        [Display(Name = "وضعیت")]
        public string? status { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;
    }
}
