using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRAVELTRIPPROJE.Models.Siniflar;

namespace TRAVELTRIPPROJE.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default 
        Context c = new Context();
        public ActionResult Index()
        {

            var degerler = c.Blogs.ToList();
            return View(degerler);
        } 
        public ActionResult About()
        {
            return View();
        } 
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
    }
}