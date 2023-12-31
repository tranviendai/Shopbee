﻿using System;
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
using X.PagedList;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public async Task<IActionResult> Index(string searchCategory, int? page, string searchName, string orderBy, string location)
        {
            ViewData["GetData"] = searchCategory;
            ViewData["GetSearch"] = searchName;
            ViewData["OrderBy"] = orderBy;
            ViewData["GetPartner"] = await _context.Partner.ToPagedListAsync(1, 100);
            ViewData["GetCategory"] = await _context.Category.ToPagedListAsync(1, 100);
            var product = from m in _context.Product.Include(p => p.Category).Include(p => p.productColor).Include(i => i.productImages).Include(i => i.Partner)
                          select m;
            if(location != null)
            {
                return View(await product.Where(e => e.Partner!.address!.Contains(location)).ToPagedListAsync(page ?? 1, 10));
            }

            if (!System.String.IsNullOrEmpty(searchCategory) && searchName == null)
            {
                if (orderBy == "Tăng Dần")
                {
                    return View(await product.Where(e => e.categoryID!.Contains(searchCategory)).OrderByDescending(e => e.price).ToPagedListAsync(page ?? 1, 10));
                }
                else if (orderBy == "Giảm Dần")
                {
                    return View(await product.Where(e => e.categoryID!.Contains(searchCategory)).OrderBy(e => e.price).ToPagedListAsync(page ?? 1, 10));
                } else if(orderBy == "Mới Nhất")
                {
                    return View(await product.Where(e => e.categoryID!.Contains(searchCategory)).OrderByDescending(e => e.postDate).ToPagedListAsync(page ?? 1, 10));
                }
                else
                {
                    return View(await product.Where(e => e.categoryID!.Contains(searchCategory)).ToPagedListAsync(page ?? 1, 10));
                }
            }
            else if (searchName != null && searchCategory == null)
            {

                if (orderBy == "Tăng Dần")
                {
                    return View(await product.Where(e => e.name!.Contains(searchName)).OrderByDescending(e => e.price).ToPagedListAsync(page ?? 1, 10));
                }
                else if (orderBy == "Giảm Dần")
                {
                    return View(await product.Where(e => e.name!.Contains(searchName)).OrderBy(e => e.price).ToPagedListAsync(page ?? 1, 10));
                }
                else if (orderBy == "Mới Nhất")
                {
                    return View(await product.Where(e => e.name!.Contains(searchName)).OrderByDescending(e => e.postDate).ToPagedListAsync(page ?? 1, 10));
                }
                else
                {
                    return View(await product.Where(e => e.name!.Contains(searchName)).ToPagedListAsync(page ?? 1, 10));
                }
            }
            else
            {
                return View(await product.ToPagedListAsync(page ?? 1, 10));
            }

        }
        public async Task<IActionResult> LocationsPartial()
        {
            var jZenoDbContext = await _context.Partner.ToPagedListAsync(1, 100);
            return PartialView("LocationsPartial", jZenoDbContext);
        }
        public async Task<IActionResult> _CategorypPartial()
        {
            var jZenoDbContext = await _context.Category.ToPagedListAsync(1, 100);
            return PartialView("_CategorypPartial", jZenoDbContext);
        }

        public async Task<IActionResult> _RelatedProducts(string? cate)
        {
            var product = from m in _context.Product.Include(p => p.Category).Include(p => p.productColor).Include(i => i.productImages).Include(i => i.Partner)
                          select m;
            var productRelated = await product.Where(p => p.categoryID == cate).ToPagedListAsync(1, 100);
            return PartialView("_RelatedProducts", productRelated);
        }

        [HttpPost]
        public async Task<JsonResult> AddComment(string message, int star, string productId, string userId, int detailOD)
        {
            try
            {
                var product = await _context.Product.FindAsync(productId);
                var detail = await _context.DetailOD.FindAsync(detailOD);
                var user = await _context.User.FindAsync(userId);

                ProductComment cmt = new ProductComment
                {
                    isComment = true,
                    comment = message,
                    product = product,
                    productId = productId,
                    User = user,
                    userId = userId,
                    evaluate = star,
                    userName = user!.fullName,
                    dateCmt = DateTime.Now
                };
                if(cmt.evaluate == 0 || cmt.evaluate == null)
                {
                    cmt.evaluate = 5;
                }
                _context.Add(cmt);

                detail!.active = true;
                _context.Update(detail);

                product!.sold += 1;
                _context.Update(product);

                await _context.SaveChangesAsync();
                return Json(cmt);
            }
            catch (Exception e)
            {
                return Json(e);
            }
        }


        public async Task<IActionResult> Details(string id, string cate)
        {
            var product1 = from m in _context.Product.Include(p => p.Category).Include(p => p.productColor).Include(i => i.productImages).Include(i => i.Partner)
                          select m;
            ViewData["GetProduct"] = await product1.Where(p => p.categoryID == cate).ToPagedListAsync(1, 100);
            

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
        [Authorize(Roles = "Partner")]
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
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Partner")]
        public async Task<IActionResult> Create([Bind("Id,name,discount,price,description,postDate,isPublish,Files,productSize,categoryID,colors,partnerID")] Product product,
            List<ProductColor>? productColor)
        {
            try
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
                    product.partnerID = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    product.postDate = DateTime.Now;
                    _context.Add(product);
                    await _context.SaveChangesAsync();
                    return Redirect("Partners/Details/" + product.partnerID);
                }
                ViewData["categoryID"] = new SelectList(_context.Category, "Id", "Id", product.categoryID);
                return View(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.ToString());
            }
        }
        [Authorize(Roles = "Partner")]
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
        [Authorize(Roles = "Partner")]
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
                return Redirect("/Manage/Products");
            }
            ViewData["categoryID"] = new SelectList(_context.Category, "Id", "Id", product.categoryID);
            return View(product);
        }
        [Authorize(Roles = "Partner")]
        public IActionResult PutColor(string id, string name)
        {
            var product = _context.ProductColor.FirstOrDefault(e => e.Id == id);
            product!.Name = name;
            _context.Update(product);
            _context.SaveChanges();
            return Json(product);
        }
        [Authorize(Roles = "Partner")]
        public IActionResult PutSize(int id, string name)
        {
            var product = _context.ProductSize.FirstOrDefault(e => e.Id == id);
            product!.name = name;
            _context.Update(product);
            _context.SaveChanges();
            return Json(product);
        }
        [Authorize(Roles = "Partner")]
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
