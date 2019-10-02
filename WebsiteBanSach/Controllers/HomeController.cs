using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanSach.DataAccessLayer;

namespace WebsiteBanSach.Controllers
{
    public class HomeController : Controller
    {
        //Ctrl + K + C: Comment
        //Ctrl + K + U: Uncomment
        //Ctrl + K + D: fomrat code
        //Ctrl + E + W: Wrap code
        //Ctrl + space: Goi y 
        GroceryEntities dbGrocery;

        public HomeController()
        {
            dbGrocery = new GroceryEntities();
        }

        public ActionResult Index()
        {
            return View("TrangChu");
        }

        public ActionResult Grocery()
        {
            //var listProducts = dbGrocery.Products
            //using (var context = new BloggingContext())
            //{
            //var blogs = dbGrocery.Products
            //    .Include(Product => Product.ima)
            //    .ToList();
            //}

            var listProducts = dbGrocery.Products
                        .ToList();
            return View(listProducts);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Title = "About";

            return View();
        }

        public ActionResult Map()
        {
            ViewBag.Message = "Google Map's Store";
            ViewBag.Title = "Map's Store";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}