using System.Threading.Tasks;
using NetCore.Models.EntitiesFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCore.Controllers;

namespace NetCore.Areas.Admin.Controllers
{
    [CheckSite]
    [Area("Admin")]
    public class CommunicatesController : Controller
    {
        private readonly ProductContext _context;

        public CommunicatesController(ProductContext context)
        {
            _context = context;
        }
        // GET: Admin/Communicates
        public async Task<ActionResult> Index()
        {
            return View(await _context.Communicate.ToListAsync());
        }

        // GET: Admin/Communicates/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Communicate communicate = await _context.Communicate.FindAsync(id);
            if (communicate == null)
            {
                return NotFound();
            }
            return View(communicate);
        }

        // GET: Admin/Communicates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Communicates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Communicate communicate)
        {
            if (ModelState.IsValid)
            {
                _context.Communicate.Add(communicate);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(communicate);
        }

        // GET: Admin/Communicates/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Communicate communicate = await _context.Communicate.FindAsync(id);
            if (communicate == null)
            {
                return NotFound();
            }
            return View(communicate);
        }

        // POST: Admin/Communicates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit( Communicate communicate)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(communicate).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(communicate);
        }

        // GET: Admin/Communicates/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Communicate communicate = await _context.Communicate.FindAsync(id);
            if (communicate == null)
            {
                return NotFound();
            }
            return View(communicate);
        }

        // POST: Admin/Communicates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Communicate communicate = await _context.Communicate.FindAsync(id);
            _context.Communicate.Remove(communicate);
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
