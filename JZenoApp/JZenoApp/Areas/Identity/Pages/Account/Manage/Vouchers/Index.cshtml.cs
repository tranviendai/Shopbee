using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JZenoApp.Data;
using JZenoApp.Models;

namespace JZenoApp.Areas.Identity.Pages.Account.Manage.Vouchers
{
    public class IndexModel : PageModel
    {
        private readonly JZenoApp.Data.JZenoDbContext _context;

        public IndexModel(JZenoApp.Data.JZenoDbContext context)
        {
            _context = context;
        }

        public IList<Voucher> Voucher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Voucher != null)
            {
                Voucher = await _context.Voucher.ToListAsync();
            }
        }
    }
}
