using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class EmergencyPhoneBook
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان محل")]
        public string? Place { get; set; }

        [Display(Name = "تلفن شهری")]
        public string? CityPhone { get; set; }

        [Display(Name = "تلفن شرکتی")]
        public string? CompanyPhone { get; set; }

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
