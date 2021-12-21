using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL_1721050229.Models;

namespace LTQL_1721050229.Controllers
{
    public class NhaCungCap229Controller : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: NhaCungCap229
        public ActionResult Index()
        {
            return View(db.NhaCungCaps.ToList());
        }

        // GET: NhaCungCap229/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap229 nhaCungCap229 = db.NhaCungCaps.Find(id);
            if (nhaCungCap229 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap229);
        }

        // GET: NhaCungCap229/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhaCungCap229/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNhaCungCap,TenNhaCungCap")] NhaCungCap229 nhaCungCap229)
        {
            if (ModelState.IsValid)
            {
                db.NhaCungCaps.Add(nhaCungCap229);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhaCungCap229);
        }

        // GET: NhaCungCap229/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap229 nhaCungCap229 = db.NhaCungCaps.Find(id);
            if (nhaCungCap229 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap229);
        }

        // POST: NhaCungCap229/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNhaCungCap,TenNhaCungCap")] NhaCungCap229 nhaCungCap229)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhaCungCap229).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhaCungCap229);
        }

        // GET: NhaCungCap229/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhaCungCap229 nhaCungCap229 = db.NhaCungCaps.Find(id);
            if (nhaCungCap229 == null)
            {
                return HttpNotFound();
            }
            return View(nhaCungCap229);
        }

        // POST: NhaCungCap229/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NhaCungCap229 nhaCungCap229 = db.NhaCungCaps.Find(id);
            db.NhaCungCaps.Remove(nhaCungCap229);
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
