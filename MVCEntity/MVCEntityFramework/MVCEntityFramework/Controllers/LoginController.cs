using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEntityFramework;

namespace MVCEntityFramework.Controllers
{
    public class LoginController : Controller
    {
        FSDTestEntities objFSDContext = new FSDTestEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult SignUp()
        {

            return View();
        }

        [HttpPost]
        public ActionResult SignUp(Person objPerson)
        {
            if (ModelState.IsValid)
            {
                objFSDContext.People.Add(objPerson);
                objFSDContext.SaveChanges();
            }
            return View();
        }
    }
}