using System.ComponentModel.DataAnnotations;

namespace JZenoApp.Models
{
    public class Voucher
    {
        [Key]
        public int? voucherID { get; set; }
        [MaxLength(20)]
        public string? name { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Vui lòng nhập giá tiền (Voucher)")]
        [Display(Name = "Giá Voucher")]
        public decimal? price { get; set; }
        public List<Bill>? Bills { get; set; } = new List<Bill>();
    }
}
