using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTutorial.Models;

namespace MvcTutorial.Controllers
{
    public class ModelController : Controller
    {
        private ModelDb db = new ModelDb();

        //
        // GET: /Model/

        public ActionResult Index()
        {
            return View(db.model.ToList());
        }

        //
        // GET: /Model/Details/5

        public ActionResult Details(int id = 0)
        {
            Model model = db.model.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        //
        // GET: /Model/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Model/Create

        [HttpPost]
        public ActionResult Create(Model model)
        {
            if (ModelState.IsValid)
            {
                db.model.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        //
        // GET: /Model/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Model model = db.model.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        //
        // POST: /Model/Edit/5

        [HttpPost]
        public ActionResult Edit(Model model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        //
        // GET: /Model/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Model model = db.model.Find(id);
            if (model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        //
        // POST: /Model/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Model model = db.model.Find(id);
            db.model.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}