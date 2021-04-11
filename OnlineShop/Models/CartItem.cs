using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    [Serializable]
    public class CartItem
    {
        public Model.EF.Product product { set; get; }
        public int Quantity { set; get; }
    }
}