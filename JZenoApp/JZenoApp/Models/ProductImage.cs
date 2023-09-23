using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JZenoApp.Models
{
    public class ProductImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public string? URL { get; set; }
        [ForeignKey("Id")]
        public string? productId { get; set; }
        public Product? Product { get; set; }
    }
}
