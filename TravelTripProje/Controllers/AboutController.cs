using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        //context sınıfında c isimli nesne türettip bu c nesnesi yardımıyla da contexte bağlı olan sınıflar içinde de hakkımızda tablosuna ulaşıp bu tabloyuda listeledim.
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}