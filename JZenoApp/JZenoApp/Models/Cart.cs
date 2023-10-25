using JZenoApp.Data;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;

namespace JZenoApp.Models
{
    public class CartItem
    {
        public Product? product { get; set; }

        [Required]
        public int? quantity { get; set; }
        public int? isUnique { get; set; }
    }
    public class Cart
    {
        List<CartItem> items { get; set; } = new List<CartItem>();
        public IEnumerable<CartItem> Items
        {
            get { return items; }
        }

       
    }
}
