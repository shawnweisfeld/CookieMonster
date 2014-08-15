using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookieMonster.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //get the cookies
            return View();
        }

        public ActionResult AddCookies()
        {
            //set the cookeis
            var str = new RandomStringGenerator.StringGenerator();

            for (int i = 0; i < 10; i++)
            {
                Response.Cookies.Add(new HttpCookie(string.Format("mycookie-{1}-{0:yyyyMMdd-hhmmdd-ffff}", DateTime.Now, i), str.GenerateString(10)));
            }

            return RedirectToAction("Index");
        }

    }
}