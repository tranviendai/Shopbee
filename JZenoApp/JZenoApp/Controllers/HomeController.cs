using JZenoApp.Data;
using JZenoApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Newtonsoft.Json;
using PayPal.Api;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Security.Claims;
using System.Text.Json.Nodes;

namespace JZenoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly JZenoDbContext _context;
        public const string CARTKEY = "cart";
        public HomeController(ILogger<HomeController> logger, JZenoDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ViewData["GetCate"] = await _context.Category.ToListAsync();
            var jZenoDbContext = _context.Product.Include(p => p.Category).Include(p => p.productColor).Include(i => i.productImages);

            return View(await jZenoDbContext.ToListAsync());
        }

        public async Task<IActionResult> CategoryPartial()
        {
            var jZenoDbContext = await _context.Category.ToListAsync();
            return PartialView("CategoryPartial", jZenoDbContext);
        }

        List<CartItem> GetCartItems()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY)!;
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart)!;
            }
            return new List<CartItem>();
        }
        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
        }

        void SaveCartSession(List<CartItem> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }
        [Route("/addcart", Name = "addcart")]
        public  IActionResult AddToCart(string? id, string? color, int? size)
        {
            var product = _context.Product
             .Where(p => p.Id == id)
             .Select(e => new Product
             {
                 Id = e.Id,
                 name = e.name,
                 Category = e.Category,
                 price = e.price,
                 discount = e.discount,
                 productColor = e.productColor!.Select(
                     c => new ProductColor
                     {
                         Id = c.Id,
                        Name = c.Name,
                        productSize = c.productSize!.Select(
                            s => new ProductSize
                            {
                                Id = s.Id,
                                name = s.name,
                                quantity = s.quantity
                            }).Where(s=>s.Id == size).ToList()
                     }).Where(c=>c.Id == color).ToList(),
                 productImages = e.productImages,
             }
            ).ToList()
             .FirstOrDefault();
            if (product == null)
                return NotFound("Không có sản phẩm");
            // Xử lý đưa vào Cart ...
            var cart = GetCartItems();

            var cartitem = cart.Find(e=>e.product!.Id == id && e.isUnique == size);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cartitem.quantity++;
            }
            else
            {
                //  Thêm mới
                cart.Add(new CartItem() { quantity = 1, product = product, isUnique = size });
            }

            // Lưu cart vào Session
            SaveCartSession(cart);
            // Chuyển đến trang hiện thị Cart
            return Json(cart);
            //return RedirectToAction(nameof(Cart));
        }
        [Route("/updatecart", Name = "updatecart")]
        [HttpPost]
        public IActionResult UpdateCart([FromForm] string productid, [FromForm] int quantity, [FromForm] int isUnique)
        {
            // Cập nhật Cart thay đổi số lượng quantity ...
            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.product!.Id == productid && p.isUnique == isUnique);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cartitem.quantity = quantity;
            }
            SaveCartSession(cart);
            // Trả về mã thành công (không có nội dung gì - chỉ để Ajax gọi)
            return Ok();
        }
        [Route("/removecart/{productid}", Name = "removecart")]
        public IActionResult RemoveCart([FromRoute] string productid)
        {
            var cart = GetCartItems();
            var cartitem = cart.Find(p => p.product!.Id == productid);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cart.Remove(cartitem);
            }
            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }
       // [Authorize(Roles = "Customer")]
        [Route("/checkout")]
        public IActionResult CheckOut()
        {
            String idGUID = Guid.NewGuid().ToString();
            var cart = GetCartItems();
            try
            {
                Bill bill = new Bill();
                bill.billID = idGUID;
                bill.date = DateTime.Now;
                bill.payment = false;
                bill.deliveryForm = true;
                //bill.voucherID = 
                bill.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier); //User Identity Name -> thay vì Name thì userID
                bill.price = (decimal?) cart.Sum(s => s.product!.price * s.quantity);
                _context.Add(bill);
                foreach (var item in cart)
                {
                    /*
                      DetailOrder detailOrder = new DetailOrder();   
                     detailOrder.billID = idGUID;
                     detailOrder.quantity = item.quantity;
                     detailOrder.price = item.product!.price;
                     detailOrder.totalPrice = item.product.price * detailOrder.quantity;
                     detailOrder.product!.productColor!.productId = item.product!.Id;                     
                     _context.Add(detailOrder);
                     */
                }
                _context.SaveChanges();
            }
            catch
            {
                return Content("Không Thành Công, Mời Bạn Check Lại Thông Tin");
            }
            ClearCart();
            return RedirectToAction("Index", "Home");
           // return Content("Thành Công Rồi Á");
        }
        [Route("/cart", Name = "cart")]
        public IActionResult Cart()
        {
            return View(GetCartItems());
        }
        public IActionResult PaymentWithPaypal(string? Cancel = null)
        {
            APIContext apiContext = PaypalConfiguration.GetAPIContext();
            var Session = HttpContext.Session;
            try
            {
                string payerId = HttpContext.Request.Query["PayerID"]!;
                if (string.IsNullOrEmpty(payerId))
                {
                    string baseURI = Request.GetDisplayUrl() + "://" + Request.Path + "/shoppingcart/PaymentWithPayPal?";
                    var guid = Convert.ToString((new Random()).Next(100000));
                    var createdPayment = this.CreatePayment(apiContext, baseURI + "guid=" + guid);
                    var links = createdPayment.links.GetEnumerator();
                    string? paypalRedirectUrl = null;
                    while (links.MoveNext())
                    {
                        Links lnk = links.Current;
                        if (lnk.rel.ToLower().Trim().Equals("approval_url"))
                        {
                            paypalRedirectUrl = lnk.href;
                        }
                    }
                    Session.SetString(guid, createdPayment.id);
                    return Redirect(paypalRedirectUrl!);
                }
                else
                {
                    var guid = Request.Query["guid"];
                    var executedPayment = ExecutePayment(apiContext, payerId, Session.Get(guid!)!.ToString()!);
                    if (executedPayment.state.ToLower() != "approved")
                    {
                        return View("FailureView");
                    }
                }
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
            //ở đây code thêm phần data khi thanh toán thành công nhé :))
            //code...
            return View("Index");
        }
        private PayPal.Api.Payment payment;
        private Payment ExecutePayment(APIContext apiContext, string payerId, string paymentId)
        {
            var paymentExecution = new PaymentExecution()
            {
                payer_id = payerId
            };
            this.payment = new Payment()
            {
                id = paymentId
            };
            return this.payment.Execute(apiContext, paymentExecution);
        }
        private Payment CreatePayment(APIContext apiContext, string redirectUrl)
        {
            var cart = GetCartItems();
            var itemList = new ItemList()
            {
                items = new List<Item>()
            };
            double giaTienHienTaiVNDtoUSD = 24325;

            foreach (var item in cart)
            {
                itemList.items.Add(new Item()
                {
                    name =  item.product!.name,
                    currency = "USD",
                    price = Math.Round(((double)(item.product.price / giaTienHienTaiVNDtoUSD)!),2).ToString(),
                    quantity = item.quantity.ToString(),
                    sku = "sku"
                });
            }
            double total =  itemList.items.Sum(s=> double.Parse(s.price) * double.Parse(s.quantity));
            var payer = new Payer()
            {
                payment_method = "paypal"
            };
            // Configure Redirect Urls here with RedirectUrls object  
            var redirUrls = new RedirectUrls()
            {
                cancel_url = redirectUrl + "&Cancel=true",
                return_url = redirectUrl
            };
            var details = new Details()
            {
                tax = "0",
                shipping = "0",
                subtotal = $"{total}"
            };
            //Final amount with details  
            var amount = new Amount()
            {
                currency = "USD",
                total = $"{total}",
                details = details
            };
            var transactionList = new List<Transaction>();
            var paypalOrderId = DateTime.Now.Ticks;
            transactionList.Add(new Transaction()
            {
                description = $"Invoice #{paypalOrderId}",
                invoice_number = paypalOrderId.ToString(), 
                amount = amount,
                item_list = itemList
            });
            this.payment = new Payment()
            {
                intent = "sale",
                payer = payer,
                transactions = transactionList,
                redirect_urls = redirUrls
            };

            return this.payment.Create(apiContext);
        }

        public async Task<IActionResult> UserDetails(string id)
        {
            var user = await _context.User.FirstOrDefaultAsync(u => u.Id == id);
            return  PartialView(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }





    }
}