using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TPWEB_Residual.Models;

namespace TPWEB_Residual.Controllers
{
    public class EcoPontosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: EcoPontos
        public async Task<ActionResult> Index()
        {
            return View(await db.EcoPontos.ToListAsync());
        }

        // GET: EcoPontos/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EcoPonto ecoPonto = await db.EcoPontos.FindAsync(id);
            if (ecoPonto == null)
            {
                return HttpNotFound();
            }
            return View(ecoPonto);
        }

        // GET: EcoPontos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EcoPontos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Tipo,Name,URL,Lng,Lat,Info")] EcoPonto ecoPonto)
        {
            if (ModelState.IsValid)
            {
                ecoPonto.DataRegisto = DateTime.Now;
                db.EcoPontos.Add(ecoPonto);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(ecoPonto);
        }

        // GET: EcoPontos/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EcoPonto ecoPonto = await db.EcoPontos.FindAsync(id);
            if (ecoPonto == null)
            {
                return HttpNotFound();
            }
            return View(ecoPonto);
        }

        // POST: EcoPontos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,DataRegisto,Tipo,Name,URL,Lng,Lat,Info")] EcoPonto ecoPonto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ecoPonto).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ecoPonto);
        }

        // GET: EcoPontos/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EcoPonto ecoPonto = await db.EcoPontos.FindAsync(id);
            if (ecoPonto == null)
            {
                return HttpNotFound();
            }
            return View(ecoPonto);
        }

        // POST: EcoPontos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            EcoPonto ecoPonto = await db.EcoPontos.FindAsync(id);
            db.EcoPontos.Remove(ecoPonto);
            await db.SaveChangesAsync();
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
