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
        public IList<Bill> Bill { get; set; } = default!;
        public string Name { get; set; }
        public async Task OnGetAsync(string id)
        {
            if (_context.Bill != null)
            {
                Bill = await _context.Bill
                .Include(b => b.User)
                .Include(b => b.Voucher).ToListAsync();
            }
            var name = _context.DetailOD.Where(s => s.billID == id).FirstOrDefault();
            //var a = _context.Product.Where(s => s.Id == name.productId).FirstOrDefault();
        }
    }
}
