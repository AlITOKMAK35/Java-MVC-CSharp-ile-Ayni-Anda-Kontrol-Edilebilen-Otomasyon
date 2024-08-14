using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proje_Takip.Models.DataContext;
using Proje_Takip.Models.ProjeTakip;

namespace Proje_Takip.Views
{
    public class PersonelProjelerisController : Controller
    {
        private ProjeTakipDBContext db = new ProjeTakipDBContext();

        // GET: PersonelProjeleris
        public ActionResult Index()
        {
            return View(db.PersonelProjeleris.ToList());
        }

        // GET: PersonelProjeleris/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonelProjeleri personelProjeleri = db.PersonelProjeleris.Find(id);
            if (personelProjeleri == null)
            {
                return HttpNotFound();
            }
            return View(personelProjeleri);
        }

        // GET: PersonelProjeleris/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonelProjeleris/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonelProjeleriId,ProjeBaslik,ProjeAciklama,OlusturulmaTarihi,OncelikDurumu,TamamlanmaOrani,TamamlanmaTarihi,TamamlanmaDurumu")] PersonelProjeleri personelProjeleri)
        {
            if (ModelState.IsValid)
            {
                db.PersonelProjeleris.Add(personelProjeleri);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personelProjeleri);
        }

        // GET: PersonelProjeleris/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonelProjeleri personelProjeleri = db.PersonelProjeleris.Find(id);
            if (personelProjeleri == null)
            {
                return HttpNotFound();
            }
            return View(personelProjeleri);
        }

        // POST: PersonelProjeleris/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonelProjeleriId,ProjeBaslik,ProjeAciklama,OlusturulmaTarihi,OncelikDurumu,TamamlanmaOrani,TamamlanmaTarihi,TamamlanmaDurumu")] PersonelProjeleri personelProjeleri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personelProjeleri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personelProjeleri);
        }

        // GET: PersonelProjeleris/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonelProjeleri personelProjeleri = db.PersonelProjeleris.Find(id);
            if (personelProjeleri == null)
            {
                return HttpNotFound();
            }
            return View(personelProjeleri);
        }

        // POST: PersonelProjeleris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonelProjeleri personelProjeleri = db.PersonelProjeleris.Find(id);
            db.PersonelProjeleris.Remove(personelProjeleri);
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
