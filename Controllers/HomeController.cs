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
        public ActionResult Index()
        {
            _log.LogError("Hello, world!");
           var urlSite = "~/Views/" + ViewBag.SiteId + "/Home";
            return View(urlSite + "/Index.cshtml");
        }
       
        #region Category
        public async Task<ActionResult> Category(int id)
        {
          
            string siteId = ViewBag.SiteId;

            var product = _context.Product.Include(p => p.Category).Where(p => !p.IsDeleted && p.CategoryId == id );
            if (product == null)
            {
                return NotFound();
            }
            return View( await product.ToListAsync());
        }
        /// <summary>
        /// Function for yolostudio
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Categories()
        {
            string siteId = ViewBag.SiteId;
            var products = _context.Product.Include(p => p.Category).Where(p => !p.IsDeleted ).OrderByDescending(m => m.UpdatedOnUtc);
            return View( products);
        }
        public async Task<ActionResult> GetListCateProduct()
        {
            string siteId = ViewBag.SiteId;
            var categories = _context.Category.Where(p => !p.IsDeleted  && p.Product.Any()).OrderByDescending(m => m.DisplayOrder);
            if (categories == null)
            {
                return NotFound();
            }
            return View( await categories.ToListAsync());
        }
        #endregion
        #region Image
        public async Task<ActionResult> Slide()
        {
            string siteId = ViewBag.SiteId;
            var slides = _context.Picture.Where(m => !m.IsDeleted  && m.TypePicture == Constants.TYPE_PICTURE.Slide);
            foreach (var item in slides)
            {
                item.ImageUrl = item.ImageUrl.Replace("\\","/");
            }
            var listSlide = await slides.ToListAsync();
            return PartialView( listSlide);
        }
        public async Task<ActionResult> GetAlbumProduct()
        {
            string siteId = ViewBag.SiteId;
            var slides = await (from product in _context.Product
                         where !product.IsDeleted && product.SiteId == siteId
                         select new ProductDTO()
                         {
                             ProductAlias = product.ProductAlias,
                             PictureSmall = product.PictureSmall
                         }).ToListAsync();
            return PartialView(slides);
        }
        public async Task<ActionResult> IconSlide()
        {
            string siteId = ViewBag.SiteId;
            var categories = _context.Category.Where(m => !m.IsDeleted );
            return PartialView( await categories.ToListAsync());
        }
        #endregion
        #region Product
        public ActionResult Details(string id)
        {
            string siteId = ViewBag.SiteId;

            var product = _context.Product.Include(p => p.Category).Where(p => !p.IsDeleted && p.ProductAlias == id );
            if (product == null)
            {
                return NotFound();
            }
            return View( product);
        }
        public async Task<ActionResult> Product()
        {
            string siteId = ViewBag.SiteId;

            var products = _context.Product.Include(p => p.Category).Where(p => !p.IsDeleted ).OrderByDescending(m => m.UpdatedOnUtc);
            if (siteId == null)
            {
                return NotFound();
            }
            return PartialView( await products.ToListAsync());
        }
        public async Task<ActionResult> GetListProduct(int id)
        {
            string siteId = ViewBag.SiteId;
            if (id == 0)
            {
                id = _context.Category.Where(p => p.SiteId == siteId).OrderBy(m => m.DisplayOrder).FirstOrDefault().CategoryId;
            }
            var products = _context.Product.Include(p => p.Category).Where(p => !p.IsDeleted && p.CategoryId == id ).OrderByDescending(m => m.UpdatedOnUtc);
            if (products == null)
            {
                return NotFound();
            }
            return View( await products.ToListAsync());
        }
        public async Task<ActionResult> GetListSameProduct(int id)
        {
            string siteId = ViewBag.SiteId;
            if (id == 0)
            {
                id = _context.Category.Where(p => p.SiteId == siteId).OrderBy(m => m.DisplayOrder).FirstOrDefault().CategoryId;
            }
            var products = await _context.Product.Include(p => p.Category).Where(p => !p.IsDeleted && p.CategoryId == id ).OrderByDescending(m => m.UpdatedOnUtc).ToListAsync();
            if (products == null)
            {
                return NotFound();
            }
            return PartialView( products);
        }
        #endregion
        #region Contact
        public async Task<ActionResult> DetailContact()
        {
            string siteId = ViewBag.SiteId;
            var contact = await _context.Contact.FirstOrDefaultAsync();
            return PartialView(contact);
        }
        public async Task<ActionResult> JsonContact()
        {
            string siteId = ViewBag.SiteId;
            var contact = await _context.Contact.FirstOrDefaultAsync();
            return Json(contact);
        }
        public ActionResult Contact()
        {
            return View( );
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
        public async Task<ActionResult> GetMenu()
        {
            string siteId = ViewBag.SiteId;
            var categories = _context.Category.Where(m => !m.IsDeleted  && m.Product.Any());

            return PartialView( await categories.ToListAsync());
        }
        public async Task<ActionResult> GetMenuStudio(int? id)
        {
            string siteId = ViewBag.SiteId;
            var products = _context.Product.Include(p => p.Category).Where(p => !p.IsDeleted );

            if (id!=null)
            {
                ViewBag.IsMenuBlack = true;
            }
            return PartialView( await products.ToListAsync());

        }
        #endregion

        public async Task<ActionResult> Filter()
        {
            string siteId = ViewBag.SiteId;
            var categories = _context.Category.Where(m => !m.IsDeleted  && m.Product.Any());
            return PartialView(await categories.ToListAsync());
        }
       
    
        public async Task<ActionResult> GetStretcher()
        {
            string siteId = ViewBag.SiteId;
            var categories = _context.Category.Where(p => !p.IsDeleted ).OrderByDescending(m => m.DisplayOrder);
            if (categories == null)
            {
                return NotFound();
            }
            return View( await categories.ToListAsync());
        }
       
    }
}