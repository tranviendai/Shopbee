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
        [ForeignKey("Id")]
        public string? productId { get; set; }
        public Product? product { get; set; }
    }
}
