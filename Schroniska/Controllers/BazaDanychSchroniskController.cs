using Schroniska.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Schroniska.Controllers
{
    public class BazaDanychSchroniskController : Controller
    {
        MojaBazaDanych _mojaBaza = new MojaBazaDanych();
        // GET: BazaDanychSchronisk
        public ActionResult Index()
        {
            var model = _mojaBaza.Schroniska.ToList();
            return View(model);
        }

        // GET: BazaDanychSchronisk/Details/5
        public ActionResult Details(int id)
        {
            var schroniska = _mojaBaza.Schroniska.Find(id);
            ViewBag.Recenzja = from r in _mojaBaza.Recenzje where r.IdSchroniska == id select r;
            var model = schroniska;
            ViewBag.ImageSrc = $"../../Content/Obrazki/00{schroniska.Id}.jpg";
            return View(model);
        }

        // GET: BazaDanychSchronisk/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BazaDanychSchronisk/Create
        [HttpPost]
        public ActionResult Create(Schronisko schronisko, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                _mojaBaza.Schroniska.Add(schronisko);
                _mojaBaza.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BazaDanychSchronisk/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _mojaBaza.Schroniska.Find(id);
            return View(model);
        }

        // POST: BazaDanychSchronisk/Edit/5
        [HttpPost]
        public ActionResult Edit(Schronisko schronisko, int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    _mojaBaza.Entry(schronisko).State = EntityState.Modified;
                    _mojaBaza.SaveChanges();
                }
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BazaDanychSchronisk/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _mojaBaza.Schroniska.Find(id);
            return View(model);
        }

        // POST: BazaDanychSchronisk/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var wyluskane = _mojaBaza.Schroniska.Find(id);
                _mojaBaza.Schroniska.Remove(wyluskane);
                _mojaBaza.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
