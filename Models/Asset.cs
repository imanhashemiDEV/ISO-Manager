using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Asset
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان  فارسی")]
        public string? Title { get; set; }

        [Display(Name = "عنوان انگلیسی")]
        public string? ETitle { get; set; }

        [Display(Name = "بازرس")]
        public string? Inspector { get; set; }

        [Display(Name = "شماره اموال")]
        public string? AssetNumber { get; set; }

        [Display(Name = "شماره سریال")]
        public string? SerialNumber { get; set; }

        [Display(Name = "محل استفاده")]
        public string? DeviceUser { get; set; }

        [Display(Name = "توضیحات")]
        public string? Description { get; set; }

        [Display(Name = "وضعیت")]
        public string? Status { get; set; }

        [Display(Name = "تاریخ بازرسی")]
        public DateTime InspectionDate { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


        // relations

        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }

    }
}
