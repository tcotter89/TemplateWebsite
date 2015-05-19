using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplateWebsite.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Forums() {
            return View();
        }

        public ActionResult RealmStatus() {
            return View();
        }
    }
}