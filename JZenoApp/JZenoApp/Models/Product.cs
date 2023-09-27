using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using JZenoApp.Enum;

namespace JZenoApp.Models
{
    public class Product
    {
        [Key]
        [StringLength(15)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Id { get; set; }

        [MaxLength(100)]
        public string? name { get; set; }
        [Range(1, 100)]
        public int? discount { get; set; }
        [Range(10000,1000000000000)]
        public double? price { get; set; }
        [MaxLength(1000)]
        public string? description { get; set; }
        public DateTime? postDate { get; set; }
        public bool? isPublish { get; set; }
        [NotMapped]
        public List<IFormFile>? Files { get; set; } = new List<IFormFile>();

        [Required]

        [ForeignKey("id")]
        public string? categoryID { get; set; }
        public Category? Category { get; set; }
        [NotMapped]
        public IEnumerable<ColorEnum> colors { get; set; } = new List<ColorEnum>();

        public List<ProductImage>? productImages { get; set; } = new List<ProductImage>();
        public List<ProductColor>? productColor { get; set; }

        [ForeignKey("Id")]
        public string? partnerID { get; set; }
        public Partner? Partner { get; set; } //Đối tác

    }
}
