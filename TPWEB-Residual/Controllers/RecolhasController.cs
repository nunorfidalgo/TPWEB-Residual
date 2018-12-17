using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TPWEB_Residual.Models;

namespace TPWEB_Residual.Controllers
{
    public class RecolhasController : Controller
    {
        private ResidualContext db = new ResidualContext();

        // GET: Recolhas
        public ActionResult Index()
        {
            return View(db.Recolhas.ToList());
        }

        // GET: Recolhas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recolha recolha = db.Recolhas.Find(id);
            if (recolha == null)
            {
                return HttpNotFound();
            }
            return View(recolha);
        }

        // GET: Recolhas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recolhas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecolhaId,Quantidade,Morada,Localizacao,DataRecolha,Descricao,DataRegisto,TipoResiduo,Estado,Material")] Recolha recolha)
        {
            if (ModelState.IsValid)
            {
                db.Recolhas.Add(recolha);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(recolha);
        }

        // GET: Recolhas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recolha recolha = db.Recolhas.Find(id);
            if (recolha == null)
            {
                return HttpNotFound();
            }
            return View(recolha);
        }

        // POST: Recolhas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecolhaId,Quantidade,Morada,Localizacao,DataRecolha,Descricao,DataRegisto,TipoResiduo,Estado,Material")] Recolha recolha)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recolha).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(recolha);
        }

        // GET: Recolhas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recolha recolha = db.Recolhas.Find(id);
            if (recolha == null)
            {
                return HttpNotFound();
            }
            return View(recolha);
        }

        // POST: Recolhas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recolha recolha = db.Recolhas.Find(id);
            db.Recolhas.Remove(recolha);
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
