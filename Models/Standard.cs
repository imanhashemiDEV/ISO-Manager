using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Standard
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان استاندارد")]
        public string? StandardName { get; set; }

        [Display(Name = "عنوان فصل")]
        public string? FaChapter { get; set; }

        [Display(Name = "عنوان بخش")]
        public string? FaSubchapter { get; set; }

        [Display(Name = "متن استاندارد")]
        public string? Fatext { get; set; }

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
