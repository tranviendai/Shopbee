using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JZenoApp.Models
{
    public class Chat
    {
        [Key]
        public string? id { get; set; }

        public bool? isActive { get; set; }

        [StringLength(50)]
        public string? nameActive { get; set; }

        [ForeignKey("Id"), InverseProperty("Senders")]
        public string? senderId { get; set; }
        public User? Sender { get; set; }

        [ForeignKey("Id"), InverseProperty("Receivers")]
        public string? receiverId { get; set; }
        public User? Receiver { get; set; }

        public List<ChatDetails>? chats { get; set; } = new List<ChatDetails>();
    }
    public class ChatDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? id { get; set; }
        public string? message { get; set; }
        public string? senderId { get; set; }

        [ForeignKey("id")]
        public string? chatId { get; set; }

        public Chat? Chat { get; set; }
        public DateTime sendDate { get; set; }

    }
}
