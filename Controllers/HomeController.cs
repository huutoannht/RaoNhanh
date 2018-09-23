using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NetCore.Models.EntitiesFramework;
using NetCore.Models.Common;
using NetCore.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Caching.Distributed;

namespace NetCore.Controllers
{
    [CheckSite]
    public class HomeController : Controller
    {
        private const string slash = "/";
        private readonly ProductContext _context;
        readonly ILogger<HomeController> _log;
        private readonly IDistributedCache _cache;
        public HomeController(ProductContext context, ILogger<HomeController> log,
           IDistributedCache cache)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _log = log;
            _cache = cache;
        }
        string urlSite = "~/Views/satmanhcuong.com/Home";
        public ActionResult Index()
        {
            _log.LogError("Hello, world!");
            urlSite = "~/Views/" + ViewBag.SiteId + "/Home";
            return View(urlSite + "/Index.cshtml");
        }
       
        #region Category
        public async Task<ActionResult> Category(int id)
        {
          
            string siteId = ViewBag.SiteId;

            var product = _context.Product.Include(p => p.Category).Where(p => !p.IsDeleted && p.CategoryId == id && p.SiteId == siteId);
            if (product == null)
            {
                return NotFound();
            }
            return View(urlSite + "/Category.cshtml", await product.ToListAsync());
        }
        /// <summary>
        /// Function for yolostudio
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Categories()
        {
            string siteId = ViewBag.SiteId;
            var products = _context.Product.Include(p => p.Category).Where(p => !p.IsDeleted && p.SiteId == siteId).OrderByDescending(m => m.UpdatedOnUtc);
            urlSite = "~/Views/" + ViewBag.SiteId + "/Home";
            return View(urlSite + "/Category.cshtml", products);
        }
        public async Task<ActionResult> GetListCateProduct()
        {
            string siteId = ViewBag.SiteId;
            var categories = _context.Category.Where(p => !p.IsDeleted && p.SiteId == siteId && p.Product.Any()).OrderByDescending(m => m.DisplayOrder);
            if (categories == null)
            {
                return NotFound();
            }
            urlSite = "~/Views/" + ViewBag.SiteId + "/Home";
            return View(urlSite + "/GetListCateProduct.cshtml", await categories.ToListAsync());
        }
        #endregion
        #region Image
        public async Task<ActionResult> Slide()
        {
            urlSite = "~/Views/" + ViewBag.SiteId + "/Home";
            string siteId = ViewBag.SiteId;
            var slides = _context.Picture.Where(m => !m.IsDeleted && m.SiteId == siteId && m.TypePicture == Constants.TYPE_PICTURE.Slide);
            foreach (var item in slides)
            {
                item.ImageUrl = item.ImageUrl.Replace("\\","/");
            }
            var listSlide = await slides.ToListAsync();
            _log.LogError(urlSite);
            return PartialView(urlSite + "/Slide.cshtml", listSlide);
        }
        public async Task<ActionResult> GetAlbumProduct()
        {
            urlSite = "~/Views/" + ViewBag.SiteId + "/Home";
            string siteId = ViewBag.SiteId;
            var slides = await (from product in _context.Product
                         where !product.IsDeleted && product.SiteId == siteId
                         select new ProductDTO()
                         {
                             ProductAlias = product.ProductAlias,
                             PictureSmall = product.PictureSmall
                         }).ToListAsync();
            return PartialView(urlSite + "/GetAlbumProduct.cshtml", slides);
        }
        public async Task<ActionResult> IconSlide()
        {
            urlSite = "~/Views/" + ViewBag.SiteId + "/Home";
            string siteId = ViewBag.SiteId;
            var categories = _context.Category.Where(m => !m.IsDeleted && m.SiteId == siteId);
            return PartialView(urlSite + "/IconSlide.cshtml", await categories.ToListAsync());
        }
        #endregion
        #region Product
        public ActionResult Details(string id)
        {
            string siteId = ViewBag.SiteId;

            var product = _context.Product.Include(p => p.Category).Where(p => !p.IsDeleted && p.ProductAlias == id && p.SiteId == siteId);
            if (product == null)
            {
                return NotFound();
            }
            return View(urlSite + "/Details.cshtml", product);
        }
        public async Task<ActionResult> Product()
        {
            string siteId = ViewBag.SiteId;

            var products = _context.Product.Include(p => p.Category).Where(p => !p.IsDeleted && p.SiteId == siteId).OrderByDescending(m => m.UpdatedOnUtc);
            if (siteId == null)
            {
                return NotFound();
            }
            return PartialView(urlSite + "/Product.cshtml", await products.ToListAsync());
        }
        public async Task<ActionResult> GetListProduct(int id)
        {
            string siteId = ViewBag.SiteId;
            if (id == 0)
            {
                id = _context.Category.Where(p => p.SiteId == siteId).OrderBy(m => m.DisplayOrder).FirstOrDefault().CategoryId;
            }
            var products = _context.Product.Include(p => p.Category).Where(p => !p.IsDeleted && p.CategoryId == id && p.SiteId == siteId).OrderByDescending(m => m.UpdatedOnUtc);
            if (products == null)
            {
                return NotFound();
            }
            urlSite = "~/Views/" + ViewBag.SiteId + "/Home";
            return View(urlSite + "/GetListProduct.cshtml", await products.ToListAsync());
        }
        public async Task<ActionResult> GetListSameProduct(int id)
        {
            string siteId = ViewBag.SiteId;
            if (id == 0)
            {
                id = _context.Category.Where(p => p.SiteId == siteId).OrderBy(m => m.DisplayOrder).FirstOrDefault().CategoryId;
            }
            var products = await _context.Product.Include(p => p.Category).Where(p => !p.IsDeleted && p.CategoryId == id && p.SiteId == siteId).OrderByDescending(m => m.UpdatedOnUtc).ToListAsync();
            if (products == null)
            {
                return NotFound();
            }
            urlSite = "~/Views/" + ViewBag.SiteId + "/Home";

            return PartialView(urlSite + "/GetListSameProduct.cshtml", products);
        }
        #endregion
        #region Contact
        public async Task<ActionResult> DetailContact()
        {
            urlSite = "~/Views/" + ViewBag.SiteId + "/Home";
            string siteId = ViewBag.SiteId;
            var contact = await _context.Contact.Where(m => m.SiteId == siteId).FirstOrDefaultAsync();
            return PartialView(urlSite + "/DetailContact.cshtml", contact);
        }
        public async Task<ActionResult> JsonContact()
        {
            urlSite = "~/Views/" + ViewBag.SiteId + "/Home";
            string siteId = ViewBag.SiteId;
            var contact = await _context.Contact.Where(m => m.SiteId == siteId).FirstOrDefaultAsync();
            return Json(contact);
        }
        public ActionResult Contact()
        {
            urlSite = "~/Views/" + ViewBag.SiteId + "/Home";
            return View(urlSite + "/Contact.cshtml");
        }
        [HttpPost]
        public async Task<ActionResult> CreateContact( Communicate communicate)
        {
            if (ModelState.IsValid)
            {
                _context.Communicate.Add(communicate);
                communicate.SiteId = ViewBag.SiteId;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(communicate);
        }
        #endregion
        #region Menu
        //SatManhCuong.com
        public async Task<ActionResult> GetMenu()
        {
            urlSite = "~/Views/" + ViewBag.SiteId + "/Home";
            string siteId = ViewBag.SiteId;
            var categories = _context.Category.Where(m => !m.IsDeleted && m.SiteId == siteId && m.Product.Any());

            return PartialView(urlSite + "/GetMenu.cshtml", await categories.ToListAsync());
        }
        //Studio
        public async Task<ActionResult> GetMenuStudio(int? id)
        {
            urlSite = "~/Views/" + ViewBag.SiteId + "/Home";
            string siteId = ViewBag.SiteId;
            var products = _context.Product.Include(p => p.Category).Where(p => !p.IsDeleted && p.SiteId == siteId);

            if (id!=null)
            {
                ViewBag.IsMenuBlack = true;
            }
            return PartialView(urlSite + "/GetMenu.cshtml", await products.ToListAsync());

        }
        #endregion

        public async Task<ActionResult> Filter()
        {
            urlSite = "~/Views/" + ViewBag.SiteId + "/Home";
            string siteId = ViewBag.SiteId;
            var categories = _context.Category.Where(m => !m.IsDeleted && m.SiteId == siteId && m.Product.Any());
            return PartialView(urlSite + "/Filter.cshtml", await categories.ToListAsync());
        }
       
    
        public async Task<ActionResult> GetStretcher()
        {
            string siteId = ViewBag.SiteId;
            var categories = _context.Category.Where(p => !p.IsDeleted && p.SiteId == siteId).OrderByDescending(m => m.DisplayOrder);
            if (categories == null)
            {
                return NotFound();
            }
            urlSite = "~/Views/" + ViewBag.SiteId + "/Home";
            return View(urlSite + "/GetListCateProduct.cshtml", await categories.ToListAsync());
        }
       
    }
}