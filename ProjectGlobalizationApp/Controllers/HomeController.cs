using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace ProjectGlobalizationApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string culture)
        {
            if (!string.IsNullOrEmpty(culture))
            {
                HttpContext.Session["culture"] = culture;
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
                return View();
            }

            culture = string.IsNullOrEmpty((string)Session["culture"]) ? "pt-br" : Session["culture"].ToString();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

            return View();
        }
    }
}
