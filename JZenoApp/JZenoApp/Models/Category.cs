using System.ComponentModel.DataAnnotations;

namespace JZenoApp.Models
{
    public class Category
    {
        [Key]
        [MaxLength(20)]
        public string? Id { get; set; }
        [MaxLength(25)]
        public string? name { get; set; }
        public string? icon { get; set; }
        public List<Product>? products {get; set; } = new List<Product>();
    }
}
