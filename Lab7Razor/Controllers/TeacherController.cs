using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab7Razor.Models;

namespace Lab7Razor.Controllers
{
    public class TeacherController : Controller
    {
        private Repository repo = new Repository();

        [HttpGet]
        public ActionResult Index()
        {
            return View(repo.Data);
        }

        [HttpPost]
        public ActionResult Index(string fname, string lname, string subject, string description)
        {
            if(ModelState.IsValid)
            {
                repo.Data.Add(
                        new Teacher
                        {
                            FirstName = fname,
                            LastName = lname,
                            Subject = subject,
                            Description = description
                        }
                    );
            }
            return View(repo.Data);
        }
        
        [HttpGet]
        public ActionResult Delete(int id)
        {
            repo.Data.RemoveAt(id);
            return View("Index", repo.Data);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(repo.Data.ElementAt(id));
        }
    }
}