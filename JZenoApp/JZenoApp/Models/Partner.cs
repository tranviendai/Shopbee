using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JZenoApp.Models
{
    public class Partner
    {
        [Key]
        public string? Id {get;set;}

        public string? name { get; set; }
        [NotMapped]
        public IFormFile? file { get; set; }
        public string? image { get; set; }

        public string? description { get; set; }

        public DateTime? dateCreated { get; set; }

        public bool? isActive { get; set; }

        public List<Product>? products { get; set; } = new List<Product>();
    }
}
