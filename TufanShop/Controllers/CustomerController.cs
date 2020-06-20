using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TufanShop.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public void LoginUser()
        {
            Console.WriteLine("Hello Onik!");
        }
    }
}
