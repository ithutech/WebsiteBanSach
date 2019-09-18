using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanSach.Models;

namespace WebsiteBanSach.Controllers
{
    public class BookController : Controller
    {
        List<Book> danhSach = new List<Book>();

        public BookController()
        {
            danhSach.Add(new Book()
            {
                Id = 1,
                Title = "Sach A",
                Image1 = "/images/book1.jpg",
                Image2 = "/images/book2.jpg"
            });
            danhSach.Add(new Book()
            {
                Id = 2,
                Title = "Sach B",
                Image1 = "/images/book2.jpg",
                Image2 = "/images/book3.jpg"
            });
            danhSach.Add(new Book()
            {
                Id = 3,
                Title = "Sach C",
                Image1 = "/images/book3.jpg",
                Image2 = "/images/book1.jpg"
            });
            danhSach.Add(new Book()
            {
                Id = 4,
                Title = "Sach D",
                Image1 = "/images/book3.jpg",
                Image2 = "/images/book2.jpg"
            });
        }
        // GET: Book
        public ActionResult Index()
        {
            return View(danhSach);
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
