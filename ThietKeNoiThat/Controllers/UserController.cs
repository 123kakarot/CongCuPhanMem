using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThietKeNoiThat.Models;

namespace ThietKeNoiThat.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        ThietKeNoiThatDataContext db = new ThietKeNoiThatDataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult category()
        {
            return View();
        }

        public ActionResult chitiet(int id)
        {
            var product = from s in db.PRODUCTs where s.ID == id select s;
            return View(product.Single());
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult Confimation()
        {
            return View();
        }
        public ActionResult cart()
        {
            return View();
        }
        public ActionResult getproduct()
        {
            var product = from p in db.PRODUCTs
                          where p.Hide == true
                          select p;
            return PartialView(product.ToList());
        }
        public ActionResult getSPIndex()
        {
            var product = from p in db.PRODUCTs
                          where p.Hide == true
                          select p;
            return PartialView(product.ToList());
        }
    }
}