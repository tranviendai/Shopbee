﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JZenoApp.Data;
using JZenoApp.Models;
using System.Security.Claims;

namespace JZenoApp.Areas.Identity.Pages.Account.Manage.Bills
{
    public class IndexModel : PageModel
    {
        private readonly JZenoApp.Data.JZenoDbContext _context;

        public IndexModel(JZenoApp.Data.JZenoDbContext context)
        {
            _context = context;
        }

        public List<Bill> Bill { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Bill != null)
            {
                Bill = await _context.Bill
                .Include(b => b.User)!
                .Include(x => x.detailsOrders)!
                .ThenInclude(p => p.Product!.Partner)!
                .Include(p=>p.detailsOrders)!.
                ThenInclude(e=>e.Product!.productImages)!
                .Include(b => b.Voucher)
                .Where(e=>e.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier))
                .ToListAsync();
            }
           
        }    
    }
}
