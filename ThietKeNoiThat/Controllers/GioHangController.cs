using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThietKeNoiThat.Models;

namespace ThietKeNoiThat.Controllers
{
    public class GioHangController : Controller
    {
        ThietKeNoiThatDataContext data = new ThietKeNoiThatDataContext();
        // GET: GioHang
        public ActionResult Index()
        {
            return View();
        }
        public List<GioHang> laygiohang()
        {
            List<GioHang> lstgiohang = Session["GioHang"] as List<GioHang>;
                if(lstgiohang==null)
            {
                lstgiohang = new List<GioHang>();
                Session["GioHang"] = lstgiohang;
            }
            return lstgiohang;
        }
        public ActionResult ThemGioHang (int idproduct,string strURL)
        {
            List<GioHang> lstgiohang = laygiohang();
            GioHang sanpham = lstgiohang.Find(n => n.idproduct == idproduct);
            if(sanpham==null)
            {
                sanpham = new GioHang(idproduct);
                lstgiohang.Add(sanpham);
                return Redirect(strURL);

            }
            else
            {
                sanpham.soluong++;
                return Redirect(strURL);
            }
        }
        public int TongSoLuong()
        {
            int tongsoluong = 0;
            List<GioHang> lstgiohang = Session["GioHang"] as List<GioHang>;
            if(lstgiohang!=null)
            {
                tongsoluong = lstgiohang.Sum(n => n.soluong);
            }
            return tongsoluong;
        }
        public double TongTien()
        {
            Double tongtien = 0;
            List<GioHang> lstgiohang = Session["GioHang"] as List<GioHang>;
            if (lstgiohang != null)
            {
                tongtien = lstgiohang.Sum(n => n.thanhtien);
            }
            return tongtien;
        }
        public ActionResult GioHang()
        {
            List<GioHang> lstgiohang = laygiohang();
            if (lstgiohang.Count == 0)
            {
                return RedirectToAction("Index", "User");
            }
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongTien = TongTien();
            return View(lstgiohang);
            
        }
        public ActionResult GioHangpartial()
        {
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongTien = TongTien();
            return PartialView();
        }
        public ActionResult XoaGioHang(int imasp)
        {
            List<GioHang> lstgiohang = laygiohang();
            GioHang sanpham = lstgiohang.SingleOrDefault(n => n.idproduct == imasp);
            if(sanpham!=null)
            {
                lstgiohang.RemoveAll(n => n.idproduct == imasp);
                return RedirectToAction("GioHang");
            }
            if(lstgiohang.Count==0)
            {
                return RedirectToAction("Index", "User");
            }
            return RedirectToAction("GioHang");

        }
        public ActionResult CapNhatGioHang( int imasp,FormCollection f)
        {
            List<GioHang> lstgiohang = laygiohang();
            GioHang sanpham = lstgiohang.SingleOrDefault(n => n.idproduct == imasp);
            if(sanpham!=null)
            {
                sanpham.soluong = int.Parse(f["txtSoLuong"].ToString());

            }
            return RedirectToAction("GioHang");
        }
        public ActionResult XoaAllGioHang()
        {
            List<GioHang> lstgiohang = laygiohang();
            lstgiohang.Clear();
            return RedirectToAction("Index", "User");
        }
    }
}