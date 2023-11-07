using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JZenoApp.Models
{
    public class ProductComment
    {
        [Key]
        public int id { get; set; }
        [MaxLength(50)]
        public string? userName { get; set; }
        [MaxLength(250)]
        public string? comment { get; set; }
        [Range(1,5)]
        public int? evaluate {get;set;}
        public bool? isComment { get; set; }
        public DateTime? dateCmt { get; set; }
        [ForeignKey("userId")]
        public string? userId { get; set; }
        public User? User { get; set; }

        [ForeignKey("Id")]
        public string? productId { get; set; }
        public Product? product { get; set; }
    }
}
