using HastaneRandevu.Models;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using static HastaneRandevu.ViewModels.Auth;

namespace HastaneRandevu.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AuthLogin form)
        {
            var post = Database.Session.Load<Hastalar>(1);
            if (post == null)
                return HttpNotFound();

            Database.Session.Delete(post);

            return RedirectToAction("home");
        }
    }
}