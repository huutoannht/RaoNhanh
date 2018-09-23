using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnalyticsController : Controller
    {
        // GET: Analytics
        public ActionResult Index()
        {
            return View();
        }

        // GET: Analytics/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Analytics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Analytics/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Analytics/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Analytics/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Analytics/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Analytics/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}