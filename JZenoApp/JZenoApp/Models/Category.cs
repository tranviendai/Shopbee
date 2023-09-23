using System.ComponentModel.DataAnnotations;

namespace JZenoApp.Models
{
    public class Category
    {
        [Key]
        [MaxLength(20)]
        public string? Id { get; set; }
        [MaxLength(25)]
        public string? Name { get; set; }
        public string? Icon { get; set; }
        public List<Product>? Products { get; set; } = new List<Product>();
    }
}
