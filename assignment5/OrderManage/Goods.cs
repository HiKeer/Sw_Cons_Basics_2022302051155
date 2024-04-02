using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    public class Goods //商品
    {
        private int Goods_ID;
        private string Goods_name;
        private string Goods_description;
        public Goods(int Goods_ID, string Goods_Name, string Goods_description)
        {
            this.Goods_ID = Goods_ID;
            this.Goods_name = Goods_Name;
            this.Goods_description = Goods_description;
        }
        public string GetGoodsName() { return Goods_name; }
        public override string ToString()
        {
            return Goods_ID + " " + Goods_name + " " + Goods_description;
        }
    }
}
