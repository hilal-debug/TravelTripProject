using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRAVELTRIPPROJE.Controllers;
using TRAVELTRIPPROJE.Models.Siniflar;

namespace TRAVELTRIPPROJE.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog 
        Context c = new Context(); 
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            //var bloglar = c.Blogs.ToList();
            return View(by);
        }
      
        public ActionResult BlogDetay(int ID)
        {

            //var BlogBul = c.Blogs.Where(x => x.ID == ID).ToList();  
            by.Deger1 = c.Blogs.Where(x => x.ID == ID).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.ID == ID).ToList();
            return View(by);
        }
    }
}