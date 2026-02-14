using System.ComponentModel.DataAnnotations;

namespace ISO_Manager.Models
{
    public class Standard
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان استاندارد")]
        public string? standard_name { get; set; }

        [Display(Name = "عنوان فصل")]
        public string? fa_chapter { get; set; }

        [Display(Name = "عنوان بخش")]
        public string? fa_subchapter { get; set; }

        [Display(Name = "متن استاندارد")]
        public string? fa_text { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;

    }
}
