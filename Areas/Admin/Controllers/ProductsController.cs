using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Test.Models.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NetCore.Controllers;
using NetCore.Models.EntitiesFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Hosting;
using NetCore.Models.Common;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace NetCore.Areas.Admin.Controllers
{
    [Authorize]
    [CheckSite]
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly ProductContext _context;
        private readonly IHostingEnvironment _environment;
        public ProductsController(ProductContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _environment = hostingEnvironment;
        }
        // GET: Admin/Products
        public async Task<ActionResult> Index()
        {
            string siteId = ViewBag.SiteId;
            var products = _context.Product.Include(p => p.Category).Where(p => !p.Deleted && p.SiteId == siteId).OrderByDescending(m => m.UpdatedOnUtc);
            return View(await products.ToListAsync());
        }

        // GET: Admin/Products/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // GET: Admin/Products/Create
        public ActionResult Create()
        {
            string siteId = ViewBag.SiteId;
            ViewBag.CategoryId = new SelectList(_context.Category.Where(m => !m.IsDeleted && m.SiteId == siteId), "CategoryId", "Name");
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, NetCore.Controllers.ParameterBasedOnFormName("save-continue", "continueEditing")]
        public async Task<ActionResult> Create(Product product,
            IFormFile filePicture, bool continueEditing)
        {
            string siteId = ViewBag.SiteId;
            if (ModelState.IsValid)
            {
                _context.Product.Add(product);
                product.CreatedOnUtc = DateTime.Now;
                product.UpdatedOnUtc = DateTime.Now;
                product.SiteId = siteId;
                if (filePicture != null && filePicture.Length > 0)
                {
                    var path = Path.Combine(_environment.WebRootPath, Constants.LocaltionImage);
                    var image = FileExtensions.UploadImage(filePicture, path);
                    product.Picture = image;
                   // product.PictureSmall = image?.ImageUrlSmall;
                }
                product.ProductAlias = product.Name?.ToFriendlyUrl() + "_" + FileExtensions.GetUniqueKey(5);
              
                TempData["Message"] = "create";
                await _context.SaveChangesAsync();
                if (continueEditing)
                {
                    return RedirectToAction("Create");
                }
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(_context.Category.Where(m => !m.IsDeleted && m.SiteId == siteId), "CategoryId", "Name", product.CategoryId);
            return View(product);
        }

        // GET: Admin/Products/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            string siteId = ViewBag.SiteId;
            ViewBag.CategoryId = new SelectList(_context.Category.Where(m => !m.IsDeleted && m.SiteId == siteId), "CategoryId", "Name", product.CategoryId);
            return View(product);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, NetCore.Controllers.ParameterBasedOnFormName("save-continue", "continueEditing")]
        public async Task<ActionResult> Edit(Product product,
            IFormFile filePicture)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(product).State = EntityState.Modified;
                product.SiteId = ViewBag.SiteId;
                product.UpdatedOnUtc = DateTime.Now;
                if (filePicture != null && filePicture.Length > 0)
                {
                    var path = Path.Combine(_environment.WebRootPath, "Cars_Upload");
                    var image = FileExtensions.UploadImage(filePicture, path);
                    product.Picture = image;
                    //product.PictureSmall = image?.ImageUrlSmall;
                }
                product.ProductAlias = product.Name?.ToFriendlyUrl() + "_" + FileExtensions.GetUniqueKey(5);
                TempData["Message"] = "update";
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(_context.Category.Where(m=>!m.IsDeleted && m.SiteId==product.SiteId), "CategoryId", "Name", product.CategoryId);
            return View(product);
        }

        // GET: Admin/Products/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            Product product = await _context.Product.FindAsync(id);
            product.Deleted = true;
            TempData["Message"] = "delete";
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<ActionResult> Publish(int? id)
        {
            Product product = await _context.Product.FindAsync(id);
            product.Published = true;
            TempData["Message"] = "update";
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
