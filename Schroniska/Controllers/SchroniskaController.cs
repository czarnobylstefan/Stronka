using Schroniska.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Schroniska.Controllers
{
    public class SchroniskaController : Controller
    {
        List<Schronisko> listaSchronisk = new List<Schronisko>();
        // GET: Schroniska
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            listaSchronisk.Add(new Schronisko { Id = 1, Miejscowosc = "Zieleniec", Nazwa = "Śmieszne wzgórza", Ocena = 9});
            listaSchronisk.Add(new Schronisko { Id = 2, Miejscowosc = "Sosonowiec", Nazwa = "Nieśmieszne wzgórza", Ocena = 5 });
            listaSchronisk.Add(new Schronisko { Id = 3, Miejscowosc = "Karpacz", Nazwa = "Bardzo nieśmieszne wzgórza", Ocena = 1 });
            var model = listaSchronisk;
            return View(model);
        }

        // GET: Schroniska/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Schroniska/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Schroniska/Create
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

        // GET: Schroniska/Edit/5
        public ActionResult Edit(int id)
        {
            var model = listaSchronisk.Find(s => s.Id == id);
            return View(model);
        }

        // POST: Schroniska/Edit/5
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

        // GET: Schroniska/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Schroniska/Delete/5
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
