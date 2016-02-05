using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GS.Portal.Web.Areas.Leave.Controllers
{
    public class LeaveController : Controller
    {
        // GET: Leave/Leave
        public ActionResult Index()
        {
            return View();
        }

        // GET: Leave/Leave/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Leave/Leave/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Leave/Leave/Create
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

        // GET: Leave/Leave/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Leave/Leave/Edit/5
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

        // GET: Leave/Leave/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Leave/Leave/Delete/5
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
