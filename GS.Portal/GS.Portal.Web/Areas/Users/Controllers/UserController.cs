using GS.Portal.Web.Areas.Users.Models;
using GS.Potal.Business;
using GS.Potal.Business.Interface;
using System.Web.Mvc;

namespace GS.Portal.Web.Areas.Users.Controllers
{
    public class UserController : Controller
    {
        IUserManager user = new UserManager();

        // GET: Users/User
        public ActionResult Index()
        {
            var userModel = new UserModels();
            userModel.MasterUser = user.GetMasterUser("eca8fd88-c37f-4090-890e-953c6f024a70");
            return View(userModel);
        }

        // GET: Users/User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Users/User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/User/Create
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

        // GET: Users/User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/User/Edit/5
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

        // GET: Users/User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/User/Delete/5
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
