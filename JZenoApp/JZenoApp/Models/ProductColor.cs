using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JZenoApp.Models
{
    public class ProductColor
    {
        [Key]
        public string? Id { get; set; }
        [StringLength(24)]
        public string? Name { get; set; }

        [ForeignKey("Id")]
        public string? productId { get; set; }
        public Product? product { get; set; }
        public List<ProductSize>? productSize { get; set; }
    }
}
