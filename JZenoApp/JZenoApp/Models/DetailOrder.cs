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
        public Bill? Bill { get; set; }

        [Display(Name = "Số lượng")]
        public int? quantity { get; set; }
        [MaxLength(30)]
        public string? size { get; set; }
        [StringLength(24)]
        public string? color { get; set; }
        [Display(Name = "Trạng Thái")]
        public int? detailStatic { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Display(Name = "Đơn giá")]
        public double? price { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Display(Name = "Thành Tiền")]
        public double? totalPrice { get; set; }
        public bool? active { get; set; }
        [ForeignKey("Id")]
        public string? productId { get; set; }
        public Product? Product { get; set; }
    }
}
