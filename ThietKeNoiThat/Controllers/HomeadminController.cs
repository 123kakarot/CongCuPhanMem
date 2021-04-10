using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThietKeNoiThat.Models;

namespace ThietKeNoiThat.Controllers
{
    public class HomeadminController : Controller
    {
        ThietKeNoiThatDataContext db = new ThietKeNoiThatDataContext();
        // GET: ADMIN/HomeAdmin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SanPham()
        {
            var product = from p in db.PRODUCTs
                          select p;
            return View(product);
        }
        public ActionResult LoaiNoiThat()
        {
            var loainoithat = from p in db.LoaiNTs
                          select p;
            return View(loainoithat);
        }
        public ActionResult CreateLNT()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult CreateLNT([Bind(Include = "IDLNT, Name, IMGPath,KieuChucNang")] PRODUCT sp, HttpPostedFileBase img)
        {

            var path = "";
            var filename = "";
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    filename = img.FileName;
                    path = Path.Combine(Server.MapPath("~/Content/ImagesProduct"), filename);
                    img.SaveAs(path);
                    sp.IMGPath = filename;
                }
                else
                {
                    sp.IMGPath = null;
                }
                db.PRODUCTs.InsertOnSubmit(sp);
                db.SubmitChanges();
                return RedirectToAction("LoaiNoiThat");
            }

            return View(sp);
        }

        public LoaiNT getIDLNT(int id)
        {
            return db.LoaiNTs.Where(m => m.IDLNT == id).FirstOrDefault();
        }
        [HttpGet]
        public ActionResult EditLNT(int id)
        {
            var editLNT = db.LoaiNTs.First(m => m.IDLNT == id);
            return View(editLNT);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult EditLNT([Bind(Include = "ID, NAME, IMGPATH,KieuChucNang")] LoaiNT lnt, HttpPostedFileBase img)
        {
            var path = "";
            var filename = "";
            LoaiNT temp = getIDLNT(lnt.IDLNT);
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    filename = DateTime.Now.ToString("dd-MM-yy-hh-mm-ss") + img.FileName;
                    path = Path.Combine(Server.MapPath("~/Content/ImagesProduct"), filename);
                    img.SaveAs(path);
                    lnt.IMGPath = filename;
                }
                temp.Name = lnt.Name;
                temp.IMGPath = lnt.IMGPath;
                UpdateModel(lnt);
                db.SubmitChanges();
                return RedirectToAction("LoaiNoiThat");
            }
            return View(lnt);
        }

        public ActionResult DeleteLNT(int id)
        {
            var deletelnt = db.LoaiNTs.First(m => m.IDLNT == id);
            return View(deletelnt);
        }

        [HttpPost]
        public ActionResult DeleteLNT(int id, FormCollection collection)
        {
            var xoa = db.LoaiNTs.Where(m => m.IDLNT == id).First();
            db.LoaiNTs.DeleteOnSubmit(xoa);
            db.SubmitChanges();
            return RedirectToAction("LoaiNoiThat");
        }
        //public ActionResult NoiThatChung()
        //{
        //    var kieuchucnang = from p in db.KieuChucNangs
        //                  select p;
        //    return View(kieuchucnang);
        //}

       
        public ActionResult CreateTT()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult CreateTT([Bind(Include = "IDTT, tentt, link,NoiDung,img")] TinTuc tt, HttpPostedFileBase img)
        {

            var path = "";
            var filename = "";
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    filename = img.FileName;
                    path = Path.Combine(Server.MapPath("~/Content/ImagesProduct"), filename);
                    img.SaveAs(path);
                    tt.img = filename;
                }
                else
                {
                    tt.img = null;
                }
                db.TinTucs.InsertOnSubmit(tt);
                db.SubmitChanges();
                return RedirectToAction("TinTuc");
            }

            return View(tt);
        }

        public TinTuc getIDTT(int id)
        {
            return db.TinTucs.Where(m => m.IDTT == id).FirstOrDefault();
        }
        [HttpGet]
        public ActionResult EditTT(int id)
        {
            var editTT = db.TinTucs.First(m => m.IDTT == id);
            return View(editTT);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult EditTT([Bind(Include = "ID, tentt, link,noidung,img")] TinTuc tt, HttpPostedFileBase img)
        {
            var path = "";
            var filename = "";
            TinTuc temp = getIDTT(tt.IDTT);
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    filename = DateTime.Now.ToString("dd-MM-yy-hh-mm-ss") + img.FileName;
                    path = Path.Combine(Server.MapPath("~/Content/ImagesProduct"), filename);
                    img.SaveAs(path);
                    tt.img = filename;
                }
                temp.tentt = tt.tentt;
                temp.img = tt.img;
                temp.link = tt.link;
                temp.NoiDung = tt.NoiDung;
                UpdateModel(tt);
                db.SubmitChanges();
                return RedirectToAction("TinTuc");
            }
            return View(tt);
        }

        public ActionResult DeleteTT(int id)
        {
            var deletett = db.TinTucs.First(m => m.IDTT == id);
            return View(deletett);
        }

        [HttpPost]
        public ActionResult DeleteTT(int id, FormCollection collection)
        {
            var xoa = db.TinTucs.Where(m => m.IDTT == id).First();
            db.TinTucs.DeleteOnSubmit(xoa);
            db.SubmitChanges();
            return RedirectToAction("TinTuc");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            var Tendn = collection["email"];
            var Matkhau = collection["pass"];
            if (string.IsNullOrEmpty(Tendn))
            {
                ViewData["Loi1"] = "Chua nhap email";
            }
            else if (string.IsNullOrEmpty(Matkhau))
            {
                ViewData["Loi2"] = "Chua nhap mat khau";
            }
            else
            {
                Admin ad = db.Admins.SingleOrDefault(n => n.TaiKhoan == Tendn && n.Password == Matkhau);
                if (ad != null)
                {
                    Session["tkadmin"] = ad;
                    return RedirectToAction("SanPham", "HomeAdmin");
                }
                else
                {
                    ViewBag.Thongbao = "Email hoặc Password chưa chính xác";
                }
            }
            return this.SanPham();
        }

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
        public ActionResult CreateProduct([Bind(Include = "ID, IMGPath, Name, LoaiNoiThat,MOTA,PRICE")] PRODUCT sp, HttpPostedFileBase img)
        {

            var path = "";
            var filename = "";
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    filename = img.FileName;
                    path = Path.Combine(Server.MapPath("~/Content/ImagesProduct"), filename);
                    img.SaveAs(path);
                    sp.IMGPath = filename;
                }
                else
                {
                    sp.IMGPath = null;
                }
                db.PRODUCTs.InsertOnSubmit(sp);
                db.SubmitChanges();
                return RedirectToAction("SanPham");
            }
            
            return View(sp);
        }

        public PRODUCT getID(int id)
        {
            return db.PRODUCTs.Where(m => m.ID == id).FirstOrDefault();
        }
        [HttpGet]
        public ActionResult EditProduct(int id)
        {
            var editproduct = db.PRODUCTs.First(m => m.ID == id);
            return View(editproduct);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult EditProduct([Bind(Include = "ID, IMGPath, Name, LoaiNoiThat,PRICE,MOTA")] PRODUCT sp, HttpPostedFileBase img)
        {
            var path = "";
            var filename = "";
            PRODUCT temp = getID(sp.ID);
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    filename = /*DateTime.Now.ToString("dd-MM-yy-hh-mm-ss") +*/ img.FileName;
                    path = Path.Combine(Server.MapPath("~/Content/ImagesProduct"), filename);
                    img.SaveAs(path);
                    sp.IMGPath = filename;
                }
                temp.Name = sp.Name;
                temp.LoaiNoiThat = sp.LoaiNoiThat;
                temp.PRICE = sp.PRICE;
                temp.IMGPath = sp.IMGPath;
                temp.MOTA = sp.MOTA;
                UpdateModel(sp);
                db.SubmitChanges();
                return RedirectToAction("SanPham");
            }
            return View(sp);
        }

        public ActionResult DeleteProduct(int id)
        {
            var deleteproduct = db.PRODUCTs.First(m => m.ID == id);
            return View(deleteproduct);
        }

        [HttpPost]
        public ActionResult DeleteProduct(int id, FormCollection collection)
        {
            var xoa = db.PRODUCTs.Where(m => m.ID == id).First();
            db.PRODUCTs.DeleteOnSubmit(xoa);
            db.SubmitChanges();
            return RedirectToAction("SanPham");
        }
      
    }
}