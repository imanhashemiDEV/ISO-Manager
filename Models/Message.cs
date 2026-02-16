using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Message
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "متن پیام")]
        public string? Text { get; set; }

        [Display(Name = "وضعیت")]
        public string? Status { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // relations

        [ForeignKey("Sender")]
        public string? SenderId { get; set; }
        public virtual User? Sender { get; set; }


        [ForeignKey("Receiver")]
        public string? ReceiverId { get; set; }
        public virtual User? Receiver { get; set; }


        [ForeignKey("Organization")]
        [Display(Name = "نام سازمان")]
        public int? OrganizationId { get; set; }
        [Display(Name = "نام سازمان")]
        public virtual Organization? Organization { get; set; }





    }
}
