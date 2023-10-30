using JZenoApp.Areas.Manage.Model;
using JZenoApp.Data;
using JZenoApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace JZenoApp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class StatisticsController : Controller
    {
        private readonly JZenoDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public StatisticsController(JZenoDbContext context, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [Route("Manage/Statistic")]
        public IActionResult Index()
        {
            List<DataPoint> dataPoints1 = new List<DataPoint>();
			List<DataPoint> dataPoints2 = new List<DataPoint>();
			List<DataPoint> dataPoints3 = new List<DataPoint>();
			List<DataPoint> dataPoints4 = new List<DataPoint>();

			List<DataPoint> dataPoints7 = new List<DataPoint>();
            List<DataPoint> dataPoints8 = new List<DataPoint>();
			List<DataPoint> dataPoints9 = new List<DataPoint>();
			var billDay1 = _context.Bill.Where(e=>e.billStatic == 0 && e.date!.Value.Day == DateTime.Now.Day).Count();
			var billDay2 = _context.Bill.Where(e => e.billStatic == 1 && e.date!.Value.Day == DateTime.Now.Day).Count();
			var billDay3 = _context.Bill.Where(e => e.billStatic == 2 && e.date!.Value.Day == DateTime.Now.Day).Count();
			var billDay4 = _context.Bill.Where(e => e.billStatic == 3 && e.date!.Value.Day == DateTime.Now.Day).Count();
			var billDay5 = _context.Bill.Where(e => e.billStatic == 4 && e.date!.Value.Day == DateTime.Now.Day).Count();
            dataPoints1.Add(new DataPoint("Chưa Xử Lý", billDay1));
            dataPoints1.Add(new DataPoint("Đã Xử Lý", billDay2));
            dataPoints1.Add(new DataPoint("Đang Giao", billDay3));
            dataPoints1.Add(new DataPoint("Đã Thanh Toán", billDay4));
            dataPoints1.Add(new DataPoint("Đã Hủy", billDay5));
            ViewBag.DataPoints0 = JsonConvert.SerializeObject(dataPoints1);
            var billDay1A = _context.Bill.Where(e => e.billStatic == 0 && e.date!.Value.Day == DateTime.Now.Day -1).Count();
			var billDay2A = _context.Bill.Where(e => e.billStatic == 1 && e.date!.Value.Day == DateTime.Now.Day -1).Count();
			var billDay3A = _context.Bill.Where(e => e.billStatic == 2 && e.date!.Value.Day == DateTime.Now.Day -1).Count();
			var billDay4A = _context.Bill.Where(e => e.billStatic == 3 && e.date!.Value.Day == DateTime.Now.Day -1).Count();
			var billDay5A = _context.Bill.Where(e => e.billStatic == 4 && e.date!.Value.Day == DateTime.Now.Day -1).Count();
            dataPoints2.Add(new DataPoint("Chưa Xử Lý", billDay1A));
            dataPoints2.Add(new DataPoint("Đã Xử Lý", billDay2A));
            dataPoints2.Add(new DataPoint("Đang Giao", billDay3A));
            dataPoints2.Add(new DataPoint("Đã Thanh Toán", billDay4A));
            dataPoints2.Add(new DataPoint("Đã Hủy", billDay5A));
            ViewBag.DataPoints1 = JsonConvert.SerializeObject(dataPoints2);
            var billDay1AA = _context.Bill.Where(e => e.billStatic == 0 && e.date!.Value.Day == DateTime.Now.Day - 2).Count();
			var billDay2AA = _context.Bill.Where(e => e.billStatic == 1 && e.date!.Value.Day == DateTime.Now.Day - 2).Count();
			var billDay3AA = _context.Bill.Where(e => e.billStatic == 2 && e.date!.Value.Day == DateTime.Now.Day - 2).Count();
			var billDay4AA = _context.Bill.Where(e => e.billStatic == 3 && e.date!.Value.Day == DateTime.Now.Day - 2).Count();
			var billDay5AA = _context.Bill.Where(e => e.billStatic == 4 && e.date!.Value.Day == DateTime.Now.Day - 2).Count();
            dataPoints3.Add(new DataPoint("Chưa Xử Lý", billDay1AA));
            dataPoints3.Add(new DataPoint("Đã Xử Lý", billDay2AA));
            dataPoints3.Add(new DataPoint("Đang Giao", billDay3AA));
            dataPoints3.Add(new DataPoint("Đã Thanh Toán", billDay4AA));
            dataPoints3.Add(new DataPoint("Đã Hủy", billDay5AA));
            ViewBag.DataPoints2 = JsonConvert.SerializeObject(dataPoints3);
            var billDay1AAA = _context.Bill.Where(e => e.billStatic == 0 && e.date!.Value.Day  == DateTime.Now.Day - 3).Count();
			var billDay2AAA = _context.Bill.Where(e => e.billStatic == 1 && e.date!.Value.Day  == DateTime.Now.Day - 3).Count();
			var billDay3AAA = _context.Bill.Where(e => e.billStatic == 2 && e.date!.Value.Day  == DateTime.Now.Day - 3).Count();
			var billDay4AAA = _context.Bill.Where(e => e.billStatic == 3 && e.date!.Value.Day  == DateTime.Now.Day - 3).Count();
			var billDay5AAA = _context.Bill.Where(e => e.billStatic == 4 && e.date!.Value.Day  == DateTime.Now.Day - 3).Count();
			dataPoints4.Add(new DataPoint("Chưa Xử Lý", billDay1AAA));
			dataPoints4.Add(new DataPoint("Đã Xử Lý", billDay2AAA));
			dataPoints4.Add(new DataPoint("Đang Giao", billDay3AAA));
			dataPoints4.Add(new DataPoint("Đã Thanh Toán", billDay4AAA));
			dataPoints4.Add(new DataPoint("Đã Hủy", billDay5AAA));
            ViewBag.DataPoints3 = JsonConvert.SerializeObject(dataPoints4);


            var billMonth1 = _context.Bill.Where(e => e.billStatic == 3 && e.date!.Value.Day == DateTime.Now.Day).Sum(e=>e.price);
			var billMonth2 = _context.Bill.Where(e => e.billStatic == 3 && e.date!.Value.Day == DateTime.Now.Day -1).Sum(e => e.price);
			var billMonth3 = _context.Bill.Where(e => e.billStatic == 3 && e.date!.Value.Day == DateTime.Now.Day -2).Sum(e=>e.price);
			var billMonth4 = _context.Bill.Where(e => e.billStatic == 3 && e.date!.Value.Day == DateTime.Now.Day -3).Sum(e=>e.price);

			dataPoints7.Add(new DataPoint("Hôm Nay", (int) billMonth1!));
			dataPoints7.Add(new DataPoint("Hôm Qua", (int)billMonth2!));
			dataPoints7.Add(new DataPoint("2 Ngày Trước", (int)billMonth3!));
			dataPoints7.Add(new DataPoint("3 Ngày Trước", (int)billMonth4!));
            ViewBag.DataPoints4 = JsonConvert.SerializeObject(dataPoints7);

            var billTh1 = _context.Bill.Where(e => e.date!.Value.Month == 1).Sum(e => e.price);
			var billTh2 = _context.Bill.Where(e => e.date!.Value.Month == 2).Sum(e => e.price);
			var billTh3 = _context.Bill.Where(e => e.date!.Value.Month == 3).Sum(e => e.price);
			var billTh4 = _context.Bill.Where(e => e.date!.Value.Month == 4).Sum(e => e.price);
			var billTh5 = _context.Bill.Where(e => e.date!.Value.Month == 5).Sum(e => e.price);
			var billTh6 = _context.Bill.Where(e => e.date!.Value.Month == 6).Sum(e => e.price);
			var billTh7 = _context.Bill.Where(e => e.date!.Value.Month == 7).Sum(e => e.price);
			var billTh8 = _context.Bill.Where(e => e.date!.Value.Month == 8).Sum(e => e.price);
			var billTh9 = _context.Bill.Where(e => e.date!.Value.Month == 9).Sum(e => e.price);
			var billTh10 = _context.Bill.Where(e => e.date!.Value.Month == 10).Sum(e => e.price);
			var billTh11 = _context.Bill.Where(e => e.date!.Value.Month == 11).Sum(e => e.price);
			var billTh12 = _context.Bill.Where(e => e.date!.Value.Month == 12).Sum(e => e.price);
			dataPoints8.Add(new DataPoint("Tháng 1", (double)billTh1!));
			dataPoints8.Add(new DataPoint("Tháng 2", (double)billTh2!));
			dataPoints8.Add(new DataPoint("Tháng 3", (double)billTh3!));
			dataPoints8.Add(new DataPoint("Tháng 4", (double)billTh4!));
			dataPoints8.Add(new DataPoint("Tháng 5", (double)billTh5!));
			dataPoints9.Add(new DataPoint("Tháng 6", (double)billTh6!));
			dataPoints9.Add(new DataPoint("Tháng 7", (double) billTh7!));
			dataPoints9.Add(new DataPoint("Tháng 8", (double) billTh8!));
			dataPoints9.Add(new DataPoint("Tháng 9", (double) billTh9!));
			dataPoints9.Add(new DataPoint("Tháng 10", (double) billTh10!));
			dataPoints9.Add(new DataPoint("Tháng 11", (double) billTh11!));
			dataPoints9.Add(new DataPoint("Tháng 12", (double) billTh12!));
			ViewBag.DataPoints5 = JsonConvert.SerializeObject(dataPoints8);
			ViewBag.DataPoints6 = JsonConvert.SerializeObject(dataPoints9);
            return View();
        }
    }
}
