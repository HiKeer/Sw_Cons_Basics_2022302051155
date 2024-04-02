using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    public class Order //订单
    {
        private int Order_ID; //订单号
        private double price; //订单金额
        private Customer customer { get; set; } //客户
        private Goods goods { get; set; } //商品
        private OrderDetails details { get; set; }
        public Order(int Order_ID, double price, Customer customer, Goods goods, OrderDetails details)
        {
            this.Order_ID = Order_ID;
            this.price = price; 
            this.customer = customer;
            this.goods = goods;
            this.details = details;
        }
        public void UpdateOrderPrice(double d) { price = d; }
        public void UpdateOrderCustomer(Customer c) { customer = c; }
        public void UpdateOrderGoods(Goods g) { goods = g; }
        public int GetOrderID() { return Order_ID; }
        public double GetPrice() { return price; }
        public string GetGoods() { return goods.GetGoodsName(); }
        public string GetCustomer() { return customer.GetCustomerName(); }

        public override bool Equals(object obj)
        {
            Order other = (Order)obj;
            return other.Order_ID == this.Order_ID
                && other.price == this.price
                && other.goods == this.goods
                && other.customer == this.customer
                || other.details == this.details;
        }

        public override string ToString()
        {
            return Order_ID + " " + price + " " + customer + " " + goods + " " + details;
        }
    }
}
