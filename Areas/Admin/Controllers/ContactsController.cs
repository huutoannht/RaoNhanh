using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using NetCore.Controllers;
using NetCore.Models.EntitiesFramework;
using Microsoft.EntityFrameworkCore;

namespace NetCore.Areas.Admin.Controllers
{
    [Authorize]
    [CheckSite]
    [Area("Admin")]
    public class ContactsController : Controller
    {
        private readonly ProductContext _context;

        public ContactsController(ProductContext context)
        {
            _context = context;
        }
        // GET: Admin/Contacts
        public async Task<ActionResult> Index()
        {
            return View(await _context.Contact.ToListAsync());
        }

        // GET: Admin/Contacts/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Contact contact = await _context.Contact.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        // GET: Admin/Contacts/Create
        public async Task<ActionResult> Create()
        {
            string siteId = ViewBag.SiteId;
            Contact contact = await _context.Contact.FirstOrDefaultAsync(m=>m.SiteId== siteId);
            return View(contact);
        }

        // POST: Admin/Contacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                contact.SiteId = ViewBag.SiteId;
                if (contact.ContactId ==0)
                {
                    _context.Contact.Add(contact);
                }
                else
                {
                    _context.Entry(contact).State = EntityState.Modified;
                }
                TempData["Message"] = "update";
                await _context.SaveChangesAsync();
                return View(contact);
            }

            return View(contact);
        }

        // GET: Admin/Contacts/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Contact contact = await _context.Contact.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        // POST: Admin/Contacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(contact).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        // GET: Admin/Contacts/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Contact contact = await _context.Contact.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        // POST: Admin/Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Contact contact = await _context.Contact.FindAsync(id);
            _context.Contact.Remove(contact);
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
