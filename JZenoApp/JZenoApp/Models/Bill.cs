using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace JZenoApp.Models
{
    public class Bill
    {
        [Key]
        public string? billID { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Ngày lập hóa đơn")]
        [DisplayFormat(DataFormatString = "{0:dd/M/yyyy HH:mm}")]
        public DateTime? date { get; set; }

        [Display(Name = "Tổng hóa đơn")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DataType(DataType.Currency)]
        public decimal? price { get; set; }

        [Display(Name = "Hình thức thanh toán")]
        public bool? payment { get; set; }
        [Display(Name = "Hình thức giao hàng")]
        public bool? deliveryForm { get; set; }

        [Display(Name ="Khuyến Mãi")]
        [ForeignKey("voucherID")]
        public int? voucherID { get; set; }
        public Voucher? Voucher { get; set; }
        [StringLength(200)]
        public string? note { get; set; }
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string? phone { get; set; }
        [Display(Name ="Trạng Thái")]
        [Range(0,5)]
        public int? billStatic {get;set;}

        [Display(Name = "Mã khách hàng")]
        [ForeignKey("Id")]
        public string? UserId { get; set; }
        public User? User { get; set; }

        public List<DetailOrder>? detailsOrders { get; set; } = new List<DetailOrder>();
    }
}
