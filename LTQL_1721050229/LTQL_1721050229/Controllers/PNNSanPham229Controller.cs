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
    public class PNNSanPham229Controller : Controller
    {
        private LTQLDbContext db = new LTQLDbContext();

        // GET: PNNSanPham229
        public ActionResult Index()
        {
            var pNNSanPham229s = db.PNNSanPham229s.Include(p => p.NhaCungCap229);
            return View(pNNSanPham229s.ToList());
        }

        // GET: PNNSanPham229/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PNNSanPham229 pNNSanPham229 = db.PNNSanPham229s.Find(id);
            if (pNNSanPham229 == null)
            {
                return HttpNotFound();
            }
            return View(pNNSanPham229);
        }

        // GET: PNNSanPham229/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCaps, "MaNhaCungCap", "TenNhaCungCap");
            return View();
        }

        // POST: PNNSanPham229/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSanPham,TenSanPham,MaNhaCungCap")] PNNSanPham229 pNNSanPham229)
        {
            if (ModelState.IsValid)
            {
                db.PNNSanPham229s.Add(pNNSanPham229);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCaps, "MaNhaCungCap", "TenNhaCungCap", pNNSanPham229.MaNhaCungCap);
            return View(pNNSanPham229);
        }

        // GET: PNNSanPham229/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PNNSanPham229 pNNSanPham229 = db.PNNSanPham229s.Find(id);
            if (pNNSanPham229 == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCaps, "MaNhaCungCap", "TenNhaCungCap", pNNSanPham229.MaNhaCungCap);
            return View(pNNSanPham229);
        }

        // POST: PNNSanPham229/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSanPham,TenSanPham,MaNhaCungCap")] PNNSanPham229 pNNSanPham229)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pNNSanPham229).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaNhaCungCap = new SelectList(db.NhaCungCaps, "MaNhaCungCap", "TenNhaCungCap", pNNSanPham229.MaNhaCungCap);
            return View(pNNSanPham229);
        }

        // GET: PNNSanPham229/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PNNSanPham229 pNNSanPham229 = db.PNNSanPham229s.Find(id);
            if (pNNSanPham229 == null)
            {
                return HttpNotFound();
            }
            return View(pNNSanPham229);
        }

        // POST: PNNSanPham229/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PNNSanPham229 pNNSanPham229 = db.PNNSanPham229s.Find(id);
            db.PNNSanPham229s.Remove(pNNSanPham229);
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
