using Hethongnongsan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hethongnongsan.Controllers
{
    public class SoldController : Controller
    {
        HethongnongsanContext db = new HethongnongsanContext();
        // GET: Sold
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult soldpro(SanPhamDaBan spdb)
        {        
                db.SanPhamDaBan.Add(spdb);
                db.SaveChanges();
            return View();
        }
    }
}