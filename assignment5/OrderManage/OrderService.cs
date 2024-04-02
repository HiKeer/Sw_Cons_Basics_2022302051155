using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    public class OrderService //订单服务
    {
        private List<Order> orders { get; set; } //List存储订单
        
        public OrderService() { orders = new List<Order>(); }

        public void OutOrderList()
        {
            foreach (Order o in orders)
            {
                Console.WriteLine(o.ToString());
            }
        }

        public void AddOrder(Order or) //添加订单
        {
            bool IsRepeat = false;
            if (orders.Any())
            {
                foreach (Order o in orders)
                {
                    if (o == or) { Console.WriteLine("Add Error! There exist repetitive orders!"); IsRepeat = true; }
                }
            }
            if (IsRepeat == false) { orders.Add(or); }
        }

        public void DeleteOrder(Order or) //删除订单
        {
            if (orders.Contains(or)) { orders.Remove(or); }
            else { Console.WriteLine("Delete Error! There is no such order!"); }
        }

        public void UpdateOrder(Order newor) //修改订单
        {
            var temp = orders.Where(a => a.GetOrderID() == newor.GetOrderID()).FirstOrDefault();
            if (temp != null) { temp = newor; }
            else { Console.WriteLine("Update Error! There is no such order!"); }
        }

        public void SearchByID(int[] id) //按订单号查询订单
        {
            var target = from idItem in id
                         from orde in orders
                         where Equals(idItem, orde.GetOrderID())
                         orderby orde.GetPrice()
                         select orde;
            List<Order> list = target.ToList();

            foreach (Order o in list)
            {
                Console.WriteLine(o.ToString());
            }
        }

        public void SearchByGoods(string[] goodsName) //按商品名称查询订单
        {
            var target = from nameItem in goodsName
                         from orde in orders
                         where Equals(nameItem, orde.GetGoods())
                         orderby orde.GetPrice()
                         select orde;
            List<Order> list = target.ToList();

            foreach (Order o in list)
            {
                Console.WriteLine(o.ToString());
            }
        }

        public void SearchByCustomer(string[] customerName) //按客户查询订单
        {
            var target = from customerNameItem in customerName
                         from orde in orders
                         where Equals(customerNameItem, orde.GetCustomer)
                         orderby orde.GetPrice()
                         select orde;
            List<Order> list = target.ToList();

            foreach (Order o in list)
            {
                Console.WriteLine(o.ToString());
            }
        }

        public void SearchByPrice(double[] price)  //按订单金额查询订单
        {
            var target = from priceItem in price
                         from orde in orders
                         where Equals(priceItem, orde.GetPrice())
                         orderby orde.GetPrice()
                         select orde;
            List<Order> list = target.ToList();

            foreach (Order o in list)
            {
                Console.WriteLine(o.ToString());
            }
        }

        public void OrderOrder(Func<Order, object> OrderType = null) //排序
        {
            if (OrderType == null) { orders.OrderBy(o => o.GetOrderID()).ToList(); }
            else { orders.OrderBy(OrderType).ToList(); }
        }
    }
}
