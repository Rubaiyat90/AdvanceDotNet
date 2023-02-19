using Lab19F.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab19F.Controllers
{
    public class HomeController : Controller
    {
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
        public ActionResult List()
        {   
            var db = new TaskEntities();
            var products = db.Products.ToList();
            return View(products);
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Product model)
        {
            var db = new TaskEntities();
            db.Products.Add(model);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult Edit(int id) 
        {
            var db = new TaskEntities();
            var pd = (from p in db.Products where p.Pid== id select p).SingleOrDefault();
            return View(pd);
        }
        [HttpPost]
        public ActionResult Edit(Product model)
        {
            var db = new TaskEntities();
            var edit = (from p in db.Products where p.Pid == model.Pid select p).SingleOrDefault();  
            db.Entry(edit).CurrentValues.SetValues(model);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult Delete(int id) 
        {
            var db = new TaskEntities();
            var pd = (from p in db.Products where p.Pid == id select p).SingleOrDefault();
            db.Products.Remove(pd);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult Details(int id)
        {
            var db = new TaskEntities();
            var pd = (from p in db.Products where p.Pid == id select p).SingleOrDefault();
            return View(pd);
        }

    }
}