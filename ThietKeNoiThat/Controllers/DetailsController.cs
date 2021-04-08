using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThietKeNoiThat.Models;

namespace ThietKeNoiThat.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Detailst
        ThietKeNoiThatDataContext db = new ThietKeNoiThatDataContext();
        
        public ActionResult Index()
        {
            
            var donhang = from i in db.DonDatHangs
                          select i;
            return View(donhang);
        }
        public ActionResult details()
        {
            return View();
        }
    }
}