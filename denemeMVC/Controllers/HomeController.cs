using denemeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace denemeMVC.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        public ActionResult Index()
        {
            var bloglar = context.Blogs
                                         .Where(i => i.Onay == true && i.Anasayfa == true)
                                        .Select(i => new BlogModel()
                                        {
                                            Id = i.Id,
                                            Baslik = i.Baslik.Length > 100 ? i.Baslik.Substring(0, 100) + "..." : i.Baslik,
                                            Aciklama = i.Aciklama,
                                            EklenmeTarihi = i.EklenmeTarihi,
                                            Anasayfa = i.Anasayfa,
                                            Onay = i.Onay,
                                            Resim = i.Resim
                                        });
                                        
            
            
            return View(bloglar.ToList());
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}