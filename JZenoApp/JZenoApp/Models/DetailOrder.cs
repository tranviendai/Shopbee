using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JZenoApp.Models
{
    public class DetailOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int? odID { get; set; }
        [ForeignKey("billID")]
        public string? billID { get; set; }

        [Display(Name = "Màu Sắc")]
        public string? color { get; set; }
        [Display(Name = "Kích Cỡ")]

        public string? size { get; set; }

        [Display(Name = "Số lượng")]
        public int? quantity { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Display(Name = "Đơn giá")]
        public double? price { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Display(Name = "Thành Tiền")]
        public double? totalPrice { get; set; }

        [ForeignKey("Id")]
        public string? productId { get; set; }
        public Product? Product { get; set; }

    }
}
