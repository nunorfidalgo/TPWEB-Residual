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
using Microsoft.AspNet.Identity;
using System.Diagnostics;

namespace TPWEB_Residual.Controllers
{
    [Authorize]
    public class VeiculosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Veiculos
        public async Task<ActionResult> Index()
        {
            //var userID = User.Identity.GetUserId();
            //Debug.WriteLine("user id: {userID}");
            return View(await db.Veiculos.ToListAsync());
        }

        // GET: Veiculos/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veiculo veiculo = await db.Veiculos.FindAsync(id);
            if (veiculo == null)
            {
                return HttpNotFound();
            }
            return View(veiculo);
        }

        // GET: Veiculos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Veiculos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "VeiculoId,Matricula,Marca,Modelo,Cor,Capacidade,DataCompra,DataRegisto,TipoVeiculo,UtilizadorId")] Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                veiculo.DataRegisto = DateTime.Now;
                //var userID = User.Identity.GetUserId();
                //Debug.WriteLine("user id: {userID}");
                veiculo.UtilizadorId = User.Identity.GetUserId();
                //veiculo.UtilizadorId = "c0e10635-ac6b-4aae-bf80-adbf174729bb";
                //veiculo.Utilizador = "c0e10635-ac6b-4aae-bf80-adbf174729bb";
                db.Veiculos.Add(veiculo);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(veiculo);
        }

        // GET: Veiculos/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veiculo veiculo = await db.Veiculos.FindAsync(id);
            if (veiculo == null)
            {
                return HttpNotFound();
            }
            return View(veiculo);
        }

        // POST: Veiculos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "VeiculoId,Matricula,Marca,Modelo,Cor,Capacidade,DataCompra,DataRegisto,TipoVeiculo,UtilizadorId")] Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(veiculo).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(veiculo);
        }

        // GET: Veiculos/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veiculo veiculo = await db.Veiculos.FindAsync(id);
            if (veiculo == null)
            {
                return HttpNotFound();
            }
            return View(veiculo);
        }

        // POST: Veiculos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Veiculo veiculo = await db.Veiculos.FindAsync(id);
            db.Veiculos.Remove(veiculo);
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
