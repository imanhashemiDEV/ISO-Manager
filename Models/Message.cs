using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISO_Manager.Models
{
    public class Message
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "متن پیام")]
        public string? text { get; set; }

        [Display(Name = "وضعیت")]
        public string? status { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        public DateTime created_at { get; set; } = DateTime.Now;

        [Display(Name = "تاریخ بروزرسانی")]
        public DateTime updated_at { get; set; } = DateTime.Now;

        // relations

        [ForeignKey("Sender")]
        public string? sender_id { get; set; }
        public User? Sender { get; set; }


        [ForeignKey("Receiver")]
        public string? receiver_id { get; set; }
        public User? Receiver { get; set; }




    }
}
