using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace ThietKeNoiThat.Models
{
    public class GioHang
    {
        ThietKeNoiThatDataContext data = new ThietKeNoiThatDataContext();
        public int idproduct { get; set; }
        public string name { get; set; }

        public string img { get; set; }
        public float dongia { get; set; }
        public int soluong { get; set; }
        public float thanhtien
        {
            get { return soluong * dongia; }
        }
        public GioHang(int ID)
        {
            idproduct = ID;
            PRODUCT sp = data.PRODUCTs.Single(n => n.ID == idproduct);
            name = sp.Name;
            img = sp.IMGPath;
            dongia = float.Parse(sp.PRICE.ToString());
            soluong = 1;
        }

    }
}