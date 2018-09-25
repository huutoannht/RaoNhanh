using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using NetCore.Controllers;
using NetCore.Models.EntitiesFramework;
using NetCore.Models.Common;
using Microsoft.EntityFrameworkCore;
using NetCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace NetCore.Areas.Admin.Controllers
{
    [Authorize]
    [CheckSite]
    [Area("Admin")]
    public class PicturesController : Controller
    {
        private readonly ProductContext _context;
        private readonly IHostingEnvironment _environment;
        public PicturesController(ProductContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _environment = hostingEnvironment;
        }
        // GET: Admin/Pictures
        public async Task<ActionResult> Index()
        {
            string siteId = ViewBag.SiteId;
            var pictures = await _context.Picture.Where(m =>   m.TypePicture == Constants.TYPE_PICTURE.Slide).ToListAsync();
            return View(pictures);
        }

        // GET: Admin/Pictures/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Picture picture = await _context.Picture.FindAsync(id);
            if (picture == null)
            {
                return NotFound();
            }
            return View(picture);
        }

        // GET: Admin/Pictures/Create
        public async Task<ActionResult> Create(int? id)
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
            ViewBag.ProductId = id;
            ViewBag.ProductName = product.Name;
            //ViewBag.JonData = Json(new
            //{
            //   dfd= _context.Picture.Where(m => m.ProductId == id).ToList()
            //});
            var model = (from p in _context.Picture
                         where p.ProductId == id
                         select new PictureDTO
                         {
                             ProductId = p.ProductId,
                             ImageUrl = p.ImageUrl.Replace("\\", "/"),
                             PictureId = p.PictureId
                         }).ToList();
            return View(model);
        }
        public ActionResult AddSlide()
        {
            return View();
        }
        public async Task<ActionResult> EditSlide(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Picture picture = await _context.Picture.FindAsync(id);
            if (picture == null)
            {
                return NotFound();
            }
            return View(picture);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditSlide(Picture picture,
        IFormFile filePicture)
        {
            _context.Entry(picture).State = EntityState.Modified;

            if (filePicture != null && filePicture.Length > 0)
            {
                var path = Path.Combine(_environment.WebRootPath, Constants.LocaltionImage);
                var image = FileExtensions.Upload(filePicture, path);

                string fileNameOld = filePicture.FileName;
                picture.ImageAlias = fileNameOld.ToFriendlyUrl() + "_" + FileExtensions.GetUniqueKey(5);
                picture.ImageName = filePicture.FileName;
                picture.ImageUrl = image;
                picture.TypePicture = Constants.TYPE_PICTURE.Slide;
            }
            picture.UpdatedOnUtc = DateTime.Now;
            await _context.SaveChangesAsync();
            TempData["Message"] = "update";
            return Redirect("~/Admin/Pictures");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddSlide(Picture picture,
          IFormFile filePicture)
        {
            var timeUtc = DateTime.UtcNow;
            TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            if (filePicture != null && filePicture.Length > 0)
            {
                var path = Path.Combine(_environment.WebRootPath, Constants.LocaltionImage);
                var image = FileExtensions.Upload(filePicture, path);

                picture.ImageName = filePicture.FileName;
                picture.ImageUrl = image;
                picture.TypePicture = Constants.TYPE_PICTURE.Slide;

                _context.Picture.Add(picture);
                await _context.SaveChangesAsync();
                TempData["Message"] = "create";
            }
            return Redirect("~/Admin/Pictures");
        }
        // POST: Admin/Pictures/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(int? productid,
            IFormFile[] filePicture)
        {
            if (ModelState.IsValid)
            {
                if (filePicture != null && filePicture.Length > 0 && filePicture[0] != null)
                {
                    List<Picture> listPicture = new List<Picture>();
                    Picture picture = new Picture();
                    foreach (var item in filePicture)
                    {
                        var path = Path.Combine(_environment.WebRootPath, Constants.LocaltionImage);
                        var image = FileExtensions.Upload(item, path);
                        if (image != null)
                        {
                            picture = new Picture();
                            picture.ProductId = productid;
                            picture.ImageName = item.FileName;
                            picture.ImageUrl = image;
                            picture.TypePicture = Constants.TYPE_PICTURE.Product;
                            picture.ImageAlias = item.FileName.ToFriendlyUrl() + "_" + FileExtensions.GetUniqueKey(5);
                            picture.CreatedOnUtc = picture.UpdatedOnUtc = DateTime.Now;
                            listPicture.Add(picture);
                        }
                    }
                    _context.Picture.AddRange(listPicture);
                    await _context.SaveChangesAsync();
                    TempData["Message"] = "create";
                }
            }
            return Redirect("~/Admin/Products");
        }

        // GET: Admin/Pictures/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Picture picture = await _context.Picture.FindAsync(id);
            if (picture == null)
            {
                return NotFound();
            }
            return View(picture);
        }

        // POST: Admin/Pictures/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Picture picture)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(picture).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(picture);
        }
        // GET: Admin/Products/Delete/5
        public async Task<ActionResult> DeleteSlide(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Picture picture = await _context.Picture.FindAsync(id);
            picture.IsDeleted = !picture.IsDeleted;
            TempData["Message"] = "delete";
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        // POST: Admin/Pictures/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<ActionResult> Delete(int id, int key)
        {
            Picture picture = await _context.Picture.FindAsync(key);
            if (picture != null)
            {
                var path = _environment.WebRootPath+ picture.ImageUrl;
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                _context.Picture.Remove(picture);
                await _context.SaveChangesAsync();
            }

            return Json(new { data = true });
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
