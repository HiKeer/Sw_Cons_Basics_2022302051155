using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    public class OrderDetails //订单明细/商品明细
    {
        private double Goods_price; //商品单价
        private int Goods_count; //商品剩余数量
        public OrderDetails(double Goods_price, int Goods_count)
        {
            this.Goods_price = Goods_price;
            this.Goods_count = Goods_count;
        }
        public override bool Equals(object obj)
        {
            OrderDetails other = (OrderDetails)obj;
            return other.Goods_price == this.Goods_price
                && other.Goods_count == this.Goods_count;
        }
        public override string ToString()
        {
            return Goods_price + " " + Goods_count;
        }
    }
}
