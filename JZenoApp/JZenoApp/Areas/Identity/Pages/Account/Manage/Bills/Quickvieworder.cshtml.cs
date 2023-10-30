using JZenoApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace JZenoApp.Areas.Identity.Pages.Account.Manage.Bills
{
    public class QuickvieworderModel : PageModel
    {
        private readonly JZenoApp.Data.JZenoDbContext _context;

        public QuickvieworderModel(JZenoApp.Data.JZenoDbContext context)
        {
            _context = context;
        }
        public Bill Bill { get; set; } = default!;
        public Product Product { get; set; } = default!;
        public IList<DetailOrder> DetailOrder { get; set; } = default!;
        public ProductColor ProductColor { get; set; } = default!;
        public ProductSize ProductSize { get; set; } = default!;
        public ProductImage ProductImage { get; set; } = default!;

        public async Task OnGetAsync(string id)
        {
            if (_context.Bill != null)
            {
                var bill = _context.Bill.Include(e => e.detailsOrders).FirstOrDefault(m => m.billID == id);
           
            }
        }
    }
}
