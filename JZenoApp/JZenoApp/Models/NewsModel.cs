using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JZenoApp.Models
{
    public class NewsModel
    {
        [Key]
        public int? Id { get; set; }

        [StringLength(100,ErrorMessage ="Vui lòng nhập ít nhất 100 kí tự")]
        public string? title { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập thông tin về bản tin")]
        public string? description { get; set; }

        [ForeignKey("Id")]
        public string? userId { get; set; }
        public User? user { get; set; }
    }
}
