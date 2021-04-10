using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using ThietKeNoiThat.Models;

namespace ThietKeNoiThat.Controllers
{
    public class DefaultController : Controller
    {
        ThietKeNoiThatDataContext db = new ThietKeNoiThatDataContext();
        // GET: Default
        public ActionResult Index()
        {

            var product = from p in db.PRODUCTs
                          select p;
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
        public ActionResult SignUp()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            var tendn = collection["username"];
            var matkhau = collection["pass"];
            if (string.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Vui Lòng Nhập Tên Đăng Nhập !";
            }
            else
                if (string.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Vui Lòng Nhập Mật Khẩu !";
            }
            else
            {
                Admin ad = db.Admins.SingleOrDefault(n => n.TaiKhoan == tendn && n.Password == matkhau);
                if (ad != null)
                {
                    Session["TKadmin"] = ad.TenAdmin;
                    return RedirectToAction("Index", "Homeadmin");
                }
                else
                    ViewBag.ThongBao = "Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng !";
            }
            return View();
        }
        [HttpGet]
        public ActionResult Dangki()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dangki(FormCollection collection, User u)
        {
            var hoten = collection["name"];

            var tendn = collection["username"];
            var matkhau = collection["pass"];

            var nhaplaimatkhau = collection["repeat-pass"];
            var email = collection["email"];
            var sdt = collection["sdt"];
            var ngaysinh = String.Format("{0:MM/dd/yyyy}", collection["username"]);
            var diachi = collection["diachi"];
            if (String.IsNullOrEmpty(hoten))
            {
                ViewData["Loi1"] = "Họ tên khách hàng không được để trống";
            }
            else if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi2"] = "Vui lòng nhập tên đăng nhập";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi3"] = "Vui lòng nhập tên mật khẩu";
            }
            else if (String.IsNullOrEmpty(nhaplaimatkhau))
            {
                ViewData["Loi4"] = "Vui lòng nhập lại mật khẩu";
            }
            else if (String.IsNullOrEmpty(email))
            {
                ViewData["Loi5"] = "Vui lòng nhập email";
            }
            else if (String.IsNullOrEmpty(sdt))
            {
                ViewData["Loi6"] = "Vui lòng nhập số điện thoại";
            }
            else
            {
                u.Hoten = hoten;
                u.TaiKhoan = tendn;
                u.Password = matkhau;
                u.email = email;
                u.SDT = sdt;
                //u.Ngaysinh = DateTime.Parse(ngaysinh);
                u.DiaChi = diachi;
                db.Users.InsertOnSubmit(u);
                db.SubmitChanges();
                return RedirectToAction("Dangnhap");
            }
            return this.Dangki();
        }
        public ActionResult Dangnhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dangnhap(FormCollection collection)
        {
            var tendn = collection["Username"];
            var matkhau = collection["Pass"];
            if (string.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Vui Lòng Nhập Tên Đăng Nhập !";
            }
            else
                if (string.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Vui Lòng Nhập Mật Khẩu !";
            }
            else
            {
                User ad = db.Users.SingleOrDefault(n => n.TaiKhoan == tendn && n.Password == matkhau);
                if (ad != null)
                {
                    Session["TKuser"] = ad.Hoten;
                    return RedirectToAction("Index", "User");
                }
                else
                    ViewBag.ThongBao = "Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng !";
            }
            return View();
        }
        public ActionResult Lienhe()
        {
            return View();
        }
        public ActionResult Forgetpass()
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
        public ActionResult getCATEGORY()
        {
            var product = from p in db.PRODUCTs
                          where p.Hide == true
                          select p;
            return PartialView(product.ToList());
        }
        public ActionResult SPTheoChuDe(int id)
        {
            var product = from s in db.PRODUCTs where s.ID == id select s;
            return View(product);
        }
    }
}