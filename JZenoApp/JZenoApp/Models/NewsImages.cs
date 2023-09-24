using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JZenoApp.Models
{
    public class NewsImages
    {
        [Key]
        public int Id { get; set; }
        public string? image { get; set; }

        [ForeignKey("Id")]
        public int? newsId { get; set; }
        public NewsModel? newsModel { get; set; }
    }
}
