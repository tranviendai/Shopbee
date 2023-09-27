using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JZenoApp.Models
{
    public class ProductSize
    {
        [Key]
        public int? Id { get; set; }

        [MaxLength(4)]
        public string? name { get; set; }
        [Range(0, 1000)]
        public double? quantity { get; set; }
        [ForeignKey("Id")]
        public string? productColorId { get; set; }
        public ProductColor? productColor { get; set; }

    }
}
