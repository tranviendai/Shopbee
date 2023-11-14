using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JZenoApp.Models
{
    public class Partner
    {
        [Key]
        public string? partnerId {get;set;}
        [StringLength(100,ErrorMessage ="Vui lòng nhập tên dưới 100 kí tự")]
        public string? name { get; set; }
        [NotMapped]
        public IFormFile? file { get; set; }
        public string? image { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập mô tả")]
        public string? description { get; set; }

        public DateTime? dateCreated { get; set; }

        public bool? isActive { get; set; }

        public List<Product>? products { get; set; } = new List<Product>();
        public User? User { get; set; }
    }
}
