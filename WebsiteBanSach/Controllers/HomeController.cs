using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteBanSach.Controllers
{
    public class HomeController : Controller
    {
        //Ctrl + K + C: Comment
        //Ctrl + K + U: Uncomment
        //Ctrl + K + D: fomrat code
        //Ctrl + E + W: Wrap code
        //Ctrl + space: Goi y 

        public ActionResult Index()
        {
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