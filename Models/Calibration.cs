using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Calibration
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان")]
        public string? Title { get; set; }

        [Display(Name = "شماره اموال")]
        public string? AssetNumber { get; set; }

        [Display(Name = "شماره سریال")]
        public string? SerialNumber { get; set; }

        [Display(Name = "صاحب")]
        public string? DeviceOwner { get; set; }

        [Display(Name = "محل استفاده")]
        public string? DeviceUser { get; set; }

        [Display(Name = "تاریخ تحویل")]
        public DateTime DeliveryDate { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ کالیبراسیون")]
        public DateTime StartCalibration { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ انقضا")]
        public DateTime EndCalibration { get; set; } = DateTime.Now;

        [Display(Name = "توضیحات")]
        public string? Description { get; set; }

        [Display(Name = "وضعیت")]
        public string? Status { get; set; }

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
