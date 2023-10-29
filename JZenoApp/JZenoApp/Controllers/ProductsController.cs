using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JZenoApp.Data;
using JZenoApp.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.Drawing;

namespace JZenoApp.Controllers
{
    //[Authorize(Roles = "Admin, Partner")]
    public class ProductsController : Controller
    {
        private readonly JZenoDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductsController(JZenoDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index(string searchCategory)
        {
            var product = from m in _context.Product.Include(p => p.Category).Include(p => p.productColor).Include(i => i.productImages).Include(i => i.Partner)
                          select m;
            if (!String.IsNullOrEmpty(searchCategory))
            {
                return View(await product.Where(e => e.categoryID!.Contains(searchCategory)).ToListAsync());
            }
            else
            {
                return View(await product.ToListAsync());
            }
            
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Category!)
                .Include(p => p.productColor!)
                .ThenInclude(p => p.productSize)
                .Include(p => p.Partner)
                .Include(p => p.productImages)
                .Include(p => p.productComment)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            Product product = new Product();
            var autoID = _context.Product.OrderByDescending(c => c.Id).FirstOrDefault();
            var lPro = _context.Product.ToList();
            if (autoID == null)
            {
                product.Id = "JZENO" + (lPro.Count).ToString();
            }
            else
            {
                product.Id = "JZENO" + (lPro.Count + 1).ToString();
            }
            ViewData["categoryID"] = new SelectList(_context.Category, "Id", "Id");
            ViewData["colorName"] = new SelectList(_context.ProductColor, "Name", "Name");
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,name,discount,price,description,postDate,isPublish,Files,productSize,categoryID,colors,partnerID")] Product product,
            List<ProductColor>? productColor)
        {
            foreach (var item in product.Files!)
            {
                string stringFileName = UploadFile(item);
                var productImgs = new ProductImage
                {
                    URL = stringFileName,
                    Product = product
                };
                _context.Add(productImgs);
            }
            foreach (var item in productColor!)
            {
                ProductColor color = new ProductColor();
                color.Id = product.Id + "-" + item.Name;
                color.product = product;
                color.productId = product.Id;
                color.Name = item.Name;
                foreach (var item1 in item.productSize!)
                {
                    ProductSize size = new ProductSize();
                    size.quantity = item1.quantity;
                    size.name = item1.name;
                    size.productColorId = item.Id;
                    size.productColor = color;
                    _context.Add(size);
                }
                _context.Add(color);
            }

            if (ModelState.IsValid)
            {
                product.partnerID = User.FindFirstValue(ClaimTypes.Name);
                product.isPublish = false;
                product.postDate = DateTime.Now;
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["categoryID"] = new SelectList(_context.Category, "Id", "Id", product.categoryID);
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Product == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.productImages!)
                .Include(p => p.productColor!)
                .ThenInclude(p => p.productSize)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["categoryID"] = new SelectList(_context.Category, "Id", "Id", product.categoryID);
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,name,discount,price,description,postDate,isPublish,Files,productSize,categoryID,colors,partnerID,productColor")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }
            var productImg = _context.ProductImage.Where(m => m.productId == id);
            if (productImg != null)
            {
                foreach (var item in productImg)
                {
                    if (!product.Files!.IsNullOrEmpty())
                    {
                        DeleteFile(item.URL!);
                        _context.Remove(item);
                    }
                }
            }
            foreach (var item in product.Files!)
            {
                string stringFileName = UploadFile(item);
                var productImgs = new ProductImage
                {
                    URL = stringFileName,
                    productId = product.Id
                };
                _context.Add(productImgs);
            }
            var productColor = _context.ProductColor.Include(e => e.productSize).Where(m => m.productId == id);
            foreach (var item in productColor)
            {

            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["categoryID"] = new SelectList(_context.Category, "Id", "Id", product.categoryID);
            return View(product);
        }
        public IActionResult PutColor(string id, string name)
        {
            var product = _context.ProductColor.FirstOrDefault(e => e.Id == id);
            product!.Name = name;
            _context.Update(product);
            _context.SaveChanges();
            return Json(product);
        }
        public IActionResult PutSize(int id, string name)
        {
            var product = _context.ProductSize.FirstOrDefault(e => e.Id == id);
            product!.name = name;
            _context.Update(product);
            _context.SaveChanges();
            return Json(product);
        }
        public IActionResult PutQuantity(int id, int quantity)
        {
            var product = _context.ProductSize.FirstOrDefault(e => e.Id == id);
            product!.quantity = quantity;
            _context.Update(product);
            _context.SaveChanges();
            return Json(product);
        }
        private bool ProductExists(string id)
        {
            return (_context.Product?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        private void DeleteFile(string file)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\products", file);

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
        }
        private string UploadFile(IFormFile file)
        {
            string? fileName = null;
            if (file != null)
            {
                string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "images/products");
                fileName = Guid.NewGuid().ToString() + "-" + file.FileName;
                string filePath = Path.Combine(uploadDir, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            return fileName!;
        }
    }
}
