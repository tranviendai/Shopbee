using JZenoApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JZenoApp.Areas.Identity.Pages.Account.Manage.Bills
{
    public class NameProductModel : PageModel
    {
        private readonly JZenoApp.Data.JZenoDbContext _context;

        public NameProductModel(JZenoApp.Data.JZenoDbContext context)
        {
            _context = context;
        }
        public Bill Bill { get; set; } = default!;
        public Product Product { get; set; } = default!;
        public DetailOrder DetailOrder { get; set; } = default!;
        public ProductColor ProductColor { get; set; } = default!;
        public ProductSize ProductSize { get; set; } = default!;
        public ProductImage ProductImage { get; set; } = default!;
        
        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Bill == null)
            {
                return NotFound();
            }

            var bill = await _context.Bill.FirstOrDefaultAsync(m => m.billID == id);
            var detailOrder = await _context.DetailOD.FirstOrDefaultAsync(m=> m.billID == bill.billID);
            var product = await _context.Product.FirstOrDefaultAsync(m => m.Id == detailOrder.productId);
            var productcolor = await _context.ProductColor.FirstOrDefaultAsync(m => m.productId == product.Id);
            var productSize = await _context.ProductSize.FirstOrDefaultAsync(m => m.productColorId == productcolor.Id);

            if (detailOrder == null)
            {
                return NotFound();
            }
            else
            {
                Bill = bill;
                DetailOrder = detailOrder;
                Product = product;
                ProductColor = productcolor;
                ProductSize = productSize;
            }
            return Page();
        }
    }
}
