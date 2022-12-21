﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_Eshop.Models;

namespace Web_Eshop.Controllers
{
    public class CricketerssController : Controller
    {
        private CricketerDBContext db = new CricketerDBContext();

        // GET: Cricketerss
        public ActionResult Index()
        {
            return View(db.Cricketers.ToList());
        }

        // GET: Cricketerss/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricketer cricketer = db.Cricketers.Find(id);
            if (cricketer == null)
            {
                return HttpNotFound();
            }
            return View(cricketer);
        }

        // GET: Cricketerss/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cricketerss/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,ODI,Test")] Cricketer cricketer)
        {
            if (ModelState.IsValid)
            {
                db.Cricketers.Add(cricketer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cricketer);
        }

        // GET: Cricketerss/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricketer cricketer = db.Cricketers.Find(id);
            if (cricketer == null)
            {
                return HttpNotFound();
            }
            return View(cricketer);
        }

        // POST: Cricketerss/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,ODI,Test")] Cricketer cricketer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cricketer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cricketer);
        }

        // GET: Cricketerss/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cricketer cricketer = db.Cricketers.Find(id);
            if (cricketer == null)
            {
                return HttpNotFound();
            }
            return View(cricketer);
        }

        // POST: Cricketerss/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cricketer cricketer = db.Cricketers.Find(id);
            db.Cricketers.Remove(cricketer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
