using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class InspectionPlace
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "دسته محل بازرسی")]
        public string? title { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;


        // relations


        //[ForeignKey("Organization")]
        //public long? organization_id { get; set; }
        //public Organization? Organization { get; set; }
    }
}
