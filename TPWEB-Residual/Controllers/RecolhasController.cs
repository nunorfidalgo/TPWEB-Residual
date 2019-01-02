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
    public class RecolhasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Recolhas
        public async Task<ActionResult> Index()
        {
            return View(await db.Recolhas.ToListAsync());
        }

        // GET: Recolhas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recolha recolha = await db.Recolhas.FindAsync(id);
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
        public async Task<ActionResult> Create([Bind(Include = "RecolhaId,Quantidade,Morada,Localizacao,DataRecolha,Descricao,DataRegisto,Material,Estado")] Recolha recolha)
        {
            if (ModelState.IsValid)
            {
                //Debug.WriteLine($"Error {recolha.ToString()}");
                recolha.DataRegisto = DateTime.Now;
                recolha.Estado = TiposEstados.Pendente;
                db.Recolhas.Add(recolha);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(recolha);
        }

        // GET: Recolhas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recolha recolha = await db.Recolhas.FindAsync(id);
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
        public async Task<ActionResult> Edit([Bind(Include = "RecolhaId,Quantidade,Morada,Localizacao,DataRecolha,Descricao,DataRegisto,Material,Estado")] Recolha recolha)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recolha).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(recolha);
        }

        // GET: Recolhas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recolha recolha = await db.Recolhas.FindAsync(id);
            if (recolha == null)
            {
                return HttpNotFound();
            }
            return View(recolha);
        }

        // POST: Recolhas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Recolha recolha = await db.Recolhas.FindAsync(id);
            db.Recolhas.Remove(recolha);
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
