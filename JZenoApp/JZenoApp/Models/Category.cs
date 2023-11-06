using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JZenoApp.Models
{
    public class Category
    {
        [Key]
        [MaxLength(20)]
        public string? Id { get; set; }
        [MaxLength(25,ErrorMessage ="Vui lòng nhập 25 kí tự")]
        [Required(ErrorMessage ="Vui lòng nhập tên loại")]
        public string? name { get; set; }
        public string? icon { get; set; }
        [NotMapped]
        public IFormFile? file { get; set; }
        public List<Product>? products {get; set; } = new List<Product>();
    }
}
