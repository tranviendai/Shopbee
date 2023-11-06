using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace JZenoApp.Models
{
    [Index(nameof(name), IsUnique = true)]
    public class Voucher
    {
        [Key]
        public int? voucherID { get; set; }
        [MaxLength(40)]
        public string? name { get; set; }
        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Vui lòng nhập giá tiền (Voucher)")]
        [Display(Name = "Giá Voucher")]
        public decimal? price { get; set; }
        public int? quantity { get; set; }
        [Required(ErrorMessage ="Vui lòng chọn thời gian bắt đầu")]
        public DateTime? startDate { get; set; }
        [Required(ErrorMessage ="Vui lòng chọn thời gian kết thúc")]
        public DateTime? endDate { get; set; }
        public List<Bill>? Bills { get; set; } = new List<Bill>();
    }
}
