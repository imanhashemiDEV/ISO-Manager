using System.ComponentModel.DataAnnotations;

namespace ISO_Manager.Models
{
    public class RigAsset
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان  فارسی")]
        public string? asset_name { get; set; }

        [Display(Name = "تعداد پیشفرض")]
        public string? default_count { get; set; }

        [Display(Name = "تعداد موجود")]
        public string? exist_count { get; set; }

        [Display(Name = "واحد")]
        public string? count_unit { get; set; }

        [Display(Name = "نوع محل")]
        public string? region { get; set; }

        [Display(Name = "محل قرارگیری")]
        public string? position_name { get; set; }

        [Display(Name = "نام دکل")] 
        public string? place { get; set; } = "rig";

        [Display(Name = "توضیحات")]
        public string? description { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;


    }
}
