using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GS.Portal.Web.Areas.leave.Controllers
{
    public class LeaveController : Controller
    {
        // GET: leave/Leave
        public ActionResult Index()
        {
            return View();
        }

        // GET: leave/Leave/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: leave/Leave/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: leave/Leave/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: leave/Leave/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: leave/Leave/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: leave/Leave/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: leave/Leave/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
