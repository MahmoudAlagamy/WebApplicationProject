using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationProject.Models;

namespace WebApplicationProject.Controllers
{
    public class HomeController : Controller
    {
        FacultySystemEntities db = new FacultySystemEntities();
        public ActionResult Index()
        {
            List<Departments> list = db.Departments.ToList();
            return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            WebsiteDesc obj = db.WebsiteDesc.FirstOrDefault();

            return View(obj);
        }
        public ActionResult Student(int id)
        {
            List<Student> STD = db.Student.Where(a=>a.Department_Id == id).ToList();
            return View(STD);
        }
    }
}