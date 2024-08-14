using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proje_Takip.Models.DataContext;
using Proje_Takip.Models.Musteri;

namespace Proje_Takip.Views
{
    public class MusteriBilgilerisController : Controller
    {
        private ProjeTakipDBContext db = new ProjeTakipDBContext();

        // GET: MusteriBilgileris
        public ActionResult Index()
        {
            return View(db.MusteriBilgileris.ToList());
        }

        // GET: MusteriBilgileris/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MusteriBilgileri musteriBilgileri = db.MusteriBilgileris.Find(id);
            if (musteriBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(musteriBilgileri);
        }

        // GET: MusteriBilgileris/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MusteriBilgileris/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MusteriBilgileriId,Ad,Soyad,Mail,TelNo,Adres,Cinsiyet")] MusteriBilgileri musteriBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.MusteriBilgileris.Add(musteriBilgileri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(musteriBilgileri);
        }

        // GET: MusteriBilgileris/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MusteriBilgileri musteriBilgileri = db.MusteriBilgileris.Find(id);
            if (musteriBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(musteriBilgileri);
        }

        // POST: MusteriBilgileris/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MusteriBilgileriId,Ad,Soyad,Mail,TelNo,Adres,Cinsiyet")] MusteriBilgileri musteriBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(musteriBilgileri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(musteriBilgileri);
        }

        // GET: MusteriBilgileris/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MusteriBilgileri musteriBilgileri = db.MusteriBilgileris.Find(id);
            if (musteriBilgileri == null)
            {
                return HttpNotFound();
            }
            return View(musteriBilgileri);
        }

        // POST: MusteriBilgileris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MusteriBilgileri musteriBilgileri = db.MusteriBilgileris.Find(id);
            db.MusteriBilgileris.Remove(musteriBilgileri);
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
