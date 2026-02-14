using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Duty
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان وظیفه")]
        public string? title { get; set; }

        [Display(Name = "مرتبه")]
        public double? step { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;

    }
}
