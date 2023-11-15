using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JZenoApp.Models
{
    public class Partner
    {
        [Key]
        public string? partnerId {get;set;}
        [StringLength(100,ErrorMessage ="Vui lòng nhập tên dưới 100 kí tự")]
        [Required(ErrorMessage ="Vui lòng nhập tên cửa hàng")]
        public string? name { get; set; }

        [StringLength(100,ErrorMessage ="Vui lòng nhập địa chỉ dưới 100 kí tự")]
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ của cửa hàng")]
        public string? address { get; set; }
        [NotMapped]
        public IFormFile? file { get; set; }
        public string? image { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập mô tả")]
        public string? description { get; set; }
        public DateTime? dateCreated { get; set; }
        public bool? isActive { get; set; }
        public List<Product>? products { get; set; } = new List<Product>();
        public List<VoucherPartner>? pVouchers { get; set; }
        public User? User { get; set; }
    }
    public class VoucherPartner
    {
        [Key]
        public string? vID { get; set; }
        [Display(Name ="Số Lượng")]
        public int? quantity { get; set; }
        [Display(Name = "Giá")]
        public decimal? price { get; set; }

        [ForeignKey("partnerId")]
        public string? partnerId { get; set; }
        public Partner? Partner { get; set; }
    }
}
