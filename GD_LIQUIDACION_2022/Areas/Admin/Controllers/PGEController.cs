using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GD_LIQUIDACION_2022.Areas.Admin.Controllers
{
    public class PGEController : Controller
    {
        // GET: Admin/PGE
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/PGE/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/PGE/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/PGE/Create
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

        // GET: Admin/PGE/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/PGE/Edit/5
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

        // GET: Admin/PGE/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/PGE/Delete/5
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
