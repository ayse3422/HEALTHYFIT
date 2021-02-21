using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models.Entity;

namespace WebApplication12.Controllers
{
    public class SalonController : Controller
    {
        // GET: Salon
        HEALTHYFITEntities db = new HEALTHYFITEntities();
        public ActionResult SalonKurslarıListele()
        {
            var deger = db.SalonKurslariListele.ToList();
            return View(deger);
        }
        public ActionResult SalonListele()
        {
            var deger = db.SalonListele.ToList();
            return View(deger);
        }
    }
}