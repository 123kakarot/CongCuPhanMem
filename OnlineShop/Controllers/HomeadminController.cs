using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class HomeadminController : Controller
    {
        // GET: ADMIN/HomeAdmin
        ThietKeNoiThatDataContext db = new ThietKeNoiThatDataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SanPham()
        {
            var product = from p in db.Products
                          select p;
            return View(product);
        }
     

        public ActionResult TinTuc()
        {
            var tintuc = from p in db.Contents
                         select p;
            return View(tintuc);
        }
        public ActionResult CreateTT()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult CreateTT([Bind(Include = "ID, Name, MetaTitle,Description,Image")] Content tt, HttpPostedFileBase img)
        {

            var path = "";
            var filename = "";
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    filename = img.FileName;
                    path = Path.Combine(Server.MapPath("~/Data/images"), filename);
                    img.SaveAs(path);
                    tt.Image = filename;
                }
                else
                {
                    tt.Image = null;
                }
                db.Contents.InsertOnSubmit(tt);
                db.SubmitChanges();
                return RedirectToAction("TinTuc");
            }

            return View(tt);
        }

        public Content getIDTT(long id)
        {
            return db.Contents.Where(m => m.ID == id).FirstOrDefault();
        }
        [HttpGet]
        public ActionResult EditTT(long id)
        {
            var editTT = db.Contents.First(m => m.ID == id);
            return View(editTT);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult EditTT([Bind(Include = "ID, Name, MetaTitle,Description,Image")] Content tt, HttpPostedFileBase img)
        {
            var path = "";
            var filename = "";
            Content temp = getIDTT(tt.ID);
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    filename = DateTime.Now.ToString("dd-MM-yy-hh-mm-ss") + img.FileName;
                    path = Path.Combine(Server.MapPath("~/Data/images"), filename);
                    img.SaveAs(path);
                    tt.Image = filename;
                }
                temp.Name = tt.Name;
                temp.Image = tt.Image;
                temp.Description = tt.Description;
                temp.MetaTitle = tt.MetaTitle;
                UpdateModel(tt);
                db.SubmitChanges();
                return RedirectToAction("TinTuc");
            }
            return View(tt);
        }

        public ActionResult DeleteTT(int id)
        {
            var deletett = db.Contents.First(m => m.ID == id);
            return View(deletett);
        }

        [HttpPost]
        public ActionResult DeleteTT(int id, FormCollection collection)
        {
            var xoa = db.Contents.Where(m => m.ID == id).First();
            db.Contents.DeleteOnSubmit(xoa);
            db.SubmitChanges();
            return RedirectToAction("TinTuc");
        }

        [HttpGet]
        //public ActionResult Login()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Login(FormCollection collection)
        //{
        //    var tendn = collection["email"];
        //    var matkhau = collection["pass"];
        //    if (string.IsNullOrEmpty(tendn))
        //    {
        //        ViewData["Loi1"] = "Chua nhap email";
        //    }
        //    else if (string.IsNullOrEmpty(matkhau))
        //    {
        //        ViewData["Loi2"] = "Chua nhap mat khau";
        //    }
        //    else
        //    {
        //        Admin ad = db.Admins.SingleOrDefault(n => n.TaiKhoan == tendn && n.Password == matkhau);
        //        if (ad != null)
        //        {
        //            Session["tkadmin"] = ad;
        //            return RedirectToAction("SanPham", "HomeAdmin");
        //        }
        //        else
        //        {
        //            ViewBag.Thongbao = "email hoac password chua dung";
        //        }
        //    }
        //    return this.SanPham();
        //}

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Forgetpass()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult CreateProduct([Bind(Include = "ID, Name, Code, Metatitle,Description,Image,Price")] Product sp, HttpPostedFileBase img)
        {

            var path = "";
            var filename = "";
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    filename = img.FileName;
                    path = Path.Combine(Server.MapPath("~/assets/client/images/"), filename);
                    img.SaveAs(path);
                    sp.Image = filename;
                }
                else
                {
                    sp.Image = null;
                }
                db.Products.InsertOnSubmit(sp);
                db.SubmitChanges();
                return RedirectToAction("SanPham");
            }

            return View(sp);
        }

        public Product getID(long id)
        {
            return db.Products.Where(m => m.ID == id).FirstOrDefault();
        }
        [HttpGet]
        public ActionResult EditProduct(long id)
        {
            var editproduct = db.Products.First(m => m.ID == id);
            return View(editproduct);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult EditProduct([Bind(Include = "ID, Name, Code, Metatitle,Description,Image,Price")] Product sp, HttpPostedFileBase img)
        {
            var path = "";
            var filename = "";
            Product temp = getID(sp.ID);
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    filename = /*DateTime.Now.ToString("dd-MM-yy-hh-mm-ss") +*/ img.FileName;
                    path = Path.Combine(Server.MapPath("~/Content/ImagesProduct"), filename);
                    img.SaveAs(path);
                    sp.Image = filename;
                }
                temp.Name = sp.Name;
                temp.Code = sp.Code;
                temp.MetaTitle = sp.MetaTitle;
                temp.Description = sp.Description;
                temp.Image = sp.Image;
                temp.Price = sp.Price;
                UpdateModel(sp);
                db.SubmitChanges();
                return RedirectToAction("SanPham");
            }
            return View(sp);
        }

        public ActionResult DeleteProduct(int id)
        {
            var deleteproduct = db.Products.First(m => m.ID == id);
            return View(deleteproduct);
        }

        [HttpPost]
        public ActionResult DeleteProduct(int id, FormCollection collection)
        {
            var xoa = db.Products.Where(m => m.ID == id).First();
            db.Products.DeleteOnSubmit(xoa);
            db.SubmitChanges();
            return RedirectToAction("SanPham");
        }
    }
}