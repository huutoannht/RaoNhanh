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
            return View();
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
            var products = _context.Product.Include(p => p.Category).Where(p => !p.IsDeleted ).OrderByDescending(m => m.UpdatedOnUtc);
            return View( products);
        }
        public async Task<ActionResult> GetListCateProduct()
        {
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
            var slides = await (from product in _context.Product
                         where !product.IsDeleted 
                         select new ProductDTO()
                         {
                             ProductAlias = product.ProductAlias,
                             PictureSmall = product.PictureSmall
                         }).ToListAsync();
            return PartialView(slides);
        }
        public async Task<ActionResult> IconSlide()
        {
            var categories = _context.Category.Where(m => !m.IsDeleted );
            return PartialView( await categories.ToListAsync());
        }
        #endregion
        #region Product
        public ActionResult Details(string id)
        {

            var product = _context.Product.Include(p => p.Category).Where(p => !p.IsDeleted && p.ProductAlias == id );
            if (product == null)
            {
                return NotFound();
            }
            return View( product);
        }
        public async Task<ActionResult> Product()
        {
            var products = _context.Product.Include(p => p.Category).Where(p => !p.IsDeleted ).OrderByDescending(m => m.UpdatedOnUtc);
            if (products == null)
            {
                return NotFound();
            }
            return PartialView( await products.ToListAsync());
        }
        public async Task<ActionResult> GetListProduct(int id)
        {
            if (id == 0)
            {
                id = _context.Category.OrderBy(m => m.DisplayOrder).FirstOrDefault().CategoryId;
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
            if (id == 0)
            {
                id = _context.Category.OrderBy(m => m.DisplayOrder).FirstOrDefault().CategoryId;
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
            var contact = await _context.Contact.FirstOrDefaultAsync();
            return PartialView(contact);
        }
        public async Task<ActionResult> JsonContact()
        {
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
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(communicate);
        }
        #endregion
        #region Menu
        public async Task<ActionResult> GetMenu()
        {
            var categories = _context.Category.Where(m => !m.IsDeleted  && m.Product.Any());

            return PartialView( await categories.ToListAsync());
        }
        public async Task<ActionResult> GetMenuStudio(int? id)
        {
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
            var categories = _context.Category.Where(m => !m.IsDeleted  && m.Product.Any());
            return PartialView(await categories.ToListAsync());
        }
       
    
        public async Task<ActionResult> GetStretcher()
        {
            var categories = _context.Category.Where(p => !p.IsDeleted ).OrderByDescending(m => m.DisplayOrder);
            if (categories == null)
            {
                return NotFound();
            }
            return View( await categories.ToListAsync());
        }
       
    }
}