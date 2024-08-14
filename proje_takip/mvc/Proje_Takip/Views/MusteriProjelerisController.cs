using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proje_Takip.Models.DataContext;
using Proje_Takip.Models.MusteriTakip;

namespace Proje_Takip.Views
{
    public class MusteriProjelerisController : Controller
    {
        private ProjeTakipDBContext db = new ProjeTakipDBContext();

        // GET: MusteriProjeleris
        public ActionResult Index()
        {
            return View(db.MusteriProjeleris.ToList());
        }

        // GET: MusteriProjeleris/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MusteriProjeleri musteriProjeleri = db.MusteriProjeleris.Find(id);
            if (musteriProjeleri == null)
            {
                return HttpNotFound();
            }
            return View(musteriProjeleri);
        }

        // GET: MusteriProjeleris/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MusteriProjeleris/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MusteriProjeleriId,firmaadi,unvan,sikayetistek,aciklama,firmaprojesi,projenumarası,projeadi,randevutarihi,uygulamatarihi,teslimtarihi")] MusteriProjeleri musteriProjeleri)
        {
            if (ModelState.IsValid)
            {
                db.MusteriProjeleris.Add(musteriProjeleri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(musteriProjeleri);
        }

        // GET: MusteriProjeleris/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MusteriProjeleri musteriProjeleri = db.MusteriProjeleris.Find(id);
            if (musteriProjeleri == null)
            {
                return HttpNotFound();
            }
            return View(musteriProjeleri);
        }

        // POST: MusteriProjeleris/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MusteriProjeleriId,firmaadi,unvan,sikayetistek,aciklama,firmaprojesi,projenumarası,projeadi,randevutarihi,uygulamatarihi,teslimtarihi")] MusteriProjeleri musteriProjeleri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(musteriProjeleri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(musteriProjeleri);
        }

        // GET: MusteriProjeleris/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MusteriProjeleri musteriProjeleri = db.MusteriProjeleris.Find(id);
            if (musteriProjeleri == null)
            {
                return HttpNotFound();
            }
            return View(musteriProjeleri);
        }

        // POST: MusteriProjeleris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MusteriProjeleri musteriProjeleri = db.MusteriProjeleris.Find(id);
            db.MusteriProjeleris.Remove(musteriProjeleri);
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
