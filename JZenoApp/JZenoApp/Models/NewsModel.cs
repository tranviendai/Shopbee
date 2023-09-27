using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JZenoApp.Models
{
    public class NewsModel
    {
        [Key]
        public int? Id { get; set; }

        [StringLength(100)]
        public string? title { get; set; }

        public string? description { get; set; }

        [ForeignKey("Id")]
        public string? userId { get; set; }
        public User? user { get; set; }
    }
}
