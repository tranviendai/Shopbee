using System.ComponentModel.DataAnnotations;

namespace JZenoApp.Enum
{
    public enum ColorEnum
    {
        [Display(Name ="Màu Đen")]
        Black,
        [Display(Name = "Màu Trắng")]
        White,
        [Display(Name = "Màu Xanh Biển")]
        Blue,
        [Display(Name = "Màu Xanh Lá")]
        Green,
        [Display(Name = "Màu Xám")]
        Grey,
        [Display(Name = "Màu Cam")]
        Orange,
        [Display(Name = "Màu Vàng")]
        Yellow,
        [Display(Name = "Màu Đỏ")]
        Red,
        [Display(Name = "Màu Hồng")]
        Pink,
        [Display(Name = "Màu Tím")]
        Violet,
        [Display(Name = "Không Xác Định")]
        Unkown
    }
}
