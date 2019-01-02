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
        public ActionResult Index()
        {
            //Markers mark = new Markers("Canada", "https://en.wikipedia.org/wiki/Canada", "informações aqui", 56.130366, -106.346771);
            ////      "name": "Canada",
            ////      "url": "https://en.wikipedia.org/wiki/Canada",
            ////      "lat": 56.130366,
            ////      "lng": -106.346771
            //ViewBag.Message = mark;
            var markers = new List<Markers> { };
            markers.Add(new Markers("Canada", "https://en.wikipedia.org/wiki/Canada", "informações Canada", 56.130366, -106.346771));
            markers.Add(new Markers("Anguilla", "https://en.wikipedia.org/wiki/Anguilla", "informações Anguilla", 18.220554, -63.068615));
            markers.Add(new Markers("Japan", "https://en.wikipedia.org/wiki/Japan", "informações Japan", 36.204824, 138.252924));
            ViewBag.Data = markers;
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