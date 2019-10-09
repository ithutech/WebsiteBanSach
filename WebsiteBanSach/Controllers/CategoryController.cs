using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanSach.Models;

namespace WebsiteBanSach.Controllers
{
    public class CategoryController : Controller
    {
        ApplicationDbContext dbContext;

        public CategoryController()
        {
            dbContext = new ApplicationDbContext();
        }
        // GET: Category
        public ActionResult Index()
        {
            return View(dbContext.Categories.ToList());
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [Authorize(Roles ="admin")]
        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(Category category)
        {
            try
            {
                // TODO: Add insert logic here
                dbContext.Categories.Add(category);
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult SaveData(Category caterory)
        {
            dbContext.Categories.Add(caterory);
            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {

                return Json(e.Message, JsonRequestBehavior.AllowGet);
            }
            
            return Json("Thêm thành công", JsonRequestBehavior.AllowGet);
        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Category/Edit/5
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

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Category/Delete/5
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
