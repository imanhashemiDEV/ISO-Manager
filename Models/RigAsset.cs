using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class RigAsset
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "عنوان  فارسی")]
        public string AssetName { get; set; }

        [Display(Name = "تعداد پیشفرض")]
        public string? DefaultCount { get; set; }

        [Display(Name = "تعداد موجود")]
        public string? ExistCount { get; set; }

        [Display(Name = "واحد")]
        public string? CountUnit { get; set; }

        [Display(Name = "نوع محل")]
        public string? Region { get; set; }

        [Display(Name = "محل قرارگیری")]
        public string? PositionName { get; set; }

        [Display(Name = "نام دکل")] 
        public string? Place { get; set; } = "rig";

        [Display(Name = "توضیحات")]
        public string? Description { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;



        //relations

        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }



    }
}
