using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NinjectConstructorInjectionWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISamurai _samurai;
        public HomeController() { }
        public HomeController(ISamurai samurai)
        {
           
            _samurai = samurai;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            Test t = new Test();

            t = new NinjectConstructorInjectionWeb.Test(new Samurai());
            string value = t.Attack();
            

            return View();
        }

        
    }
}
