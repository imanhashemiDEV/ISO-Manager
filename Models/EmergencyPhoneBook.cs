using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class EmergencyPhoneBook
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان محل")]
        public string? place { get; set; }

        [Display(Name = "تلفن شهری")]
        public string? city_phone { get; set; }

        [Display(Name = "تلفن شرکتی")]
        public string? company_phone { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;

        [ForeignKey("Organization")]
        public int? organization_id { get; set; }
        public Organization? Organization;


    }
}
