using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_Lab1.Models;

namespace WebApplication_Lab1.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            Student[] s = new Student[10];
            for (int i=0; i<10; i++)
            {
                Student st = new Student();
                st.Id = (i+1);
                st.Name = (i+1).ToString();
                st.Cgpa = 3.80f;

                s[i] = st;
            }
            ViewBag.Students = s; 

           return View();
        }

        public ActionResult Logout()
        {
            return View();
        }

        public ActionResult StudentsDetails()
        {

            return View();
        }
    }

}