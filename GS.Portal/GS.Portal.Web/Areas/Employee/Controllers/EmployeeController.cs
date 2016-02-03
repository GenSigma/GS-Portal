using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GS.Portal.Web.Areas.Employee.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee/Employee
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employee/Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Employee/SaveEmployeeDetails
        [HttpPost]
        public ActionResult SaveEmployeeDetails(FormCollection collection)
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

        // GET: Employee/Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Employee/Edit/5
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

        // GET: Employee/Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Employee/Delete/5
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
