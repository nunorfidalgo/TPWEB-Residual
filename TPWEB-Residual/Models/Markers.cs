using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Exemplo:
//markers = [
//   {
//     "name": "Canada",
//     "url": "https://en.wikipedia.org/wiki/Canada",
//     "lat": 56.130366,
//     "lng": -106.346771
//   },
//   {
//     "name": "Anguilla",
//     "url": "https://en.wikipedia.org/wiki/Anguilla",
//     "lat": 18.220554,
//     "lng": -63.068615
//   },
//   {
//     "name": "Japan",
//     "url": "https://en.wikipedia.org/wiki/Japan",
//     "lat": 36.204824,
//     "lng": 138.252924
//   }
//];

namespace TPWEB_Residual.Models
{
    public class Markers
    {
        private string name;
        private string url;
        private string info;
        private double lat;
        private double lng;

        public Markers(string name, string url, string info, double lat, double lng)
        {
            this.name = name;
            this.url = url;
            this.info = info;
            this.lat = lat;
            this.lng = lng;
        }

        public string Name { get => name; set => name = value; }
        public string URL { get => url; set => url = value; }
        public double Lng { get => lng; set => lng = value; }
        public double Lat { get => lat; set => lat = value; }
        public string Info { get => info; set => info = value; }
    }
}