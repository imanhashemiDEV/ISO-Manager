using System.ComponentModel.DataAnnotations;

namespace ISO_Manager.Models
{
    public class ClothGroup
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان گروه")]
        public string? name { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;

    }
}
