using JZenoApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JZenoApp.Controllers
{
    public class VoucherController : Controller
    {
        private readonly ILogger<VoucherController> _logger;
        private readonly JZenoDbContext _context;
        public VoucherController(ILogger<VoucherController> logger, JZenoDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return _context.Voucher != null ?
                        View(await _context.Voucher.ToListAsync()) :
                        Problem("Entity set 'JZenoDbContext.Voucher'  is null.");
        }
        public IActionResult Index1()
        {
            return View();
        }
    }
}
