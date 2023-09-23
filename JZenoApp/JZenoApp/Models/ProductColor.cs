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
    public class ProductSize
    {
        [Key]
        public int? Id { get; set; }

        [MaxLength(4)]
        public string? name { get; set; }
        [Range(0,1000)]
        public double? quantity { get; set; }

        [ForeignKey("Id")]
        public string? colorId { get; set; }
        public ProductColor? productColor { get; set; }
    }
}
