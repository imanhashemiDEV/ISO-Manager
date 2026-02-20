using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class WorkPlace
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="نام اداره الزامی است")]
        [Display(Name = "عنوان محل کار")]
        public string? Title { get; set; }

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
