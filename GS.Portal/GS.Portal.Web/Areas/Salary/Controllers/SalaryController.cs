using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GS.Portal.Web.Areas.Salary.Controllers
{
    public class SalaryController : Controller
    {
        // GET: Salary/Salary
        public ActionResult Index()
        {
            return View();
        }

        // GET: Salary/Salary/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Salary/Salary/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salary/Salary/Create
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

        // GET: Salary/Salary/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Salary/Salary/Edit/5
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

        // GET: Salary/Salary/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Salary/Salary/Delete/5
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
