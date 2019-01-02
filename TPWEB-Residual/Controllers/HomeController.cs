using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPWEB_Residual.Models;

namespace TPWEB_Residual.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            //Markers mark = new Markers("Canada", "https://en.wikipedia.org/wiki/Canada", "informações aqui", 56.130366, -106.346771);
            ////      "name": "Canada",
            ////      "url": "https://en.wikipedia.org/wiki/Canada",
            ////      "lat": 56.130366,
            ////      "lng": -106.346771
            //ViewBag.Message = mark;


            //var data = db.EcoPontos.ToList();
            List<EcoPonto> ecopontos = new List<EcoPonto>();
            ecopontos = db.EcoPontos.ToList();
            ViewBag.Message = ecopontos;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}