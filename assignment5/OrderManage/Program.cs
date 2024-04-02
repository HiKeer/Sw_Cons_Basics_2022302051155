using System;
using System.Collections.Specialized;
using System.Reflection.Metadata.Ecma335;

namespace OrderManage
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order(10001, 1000, new Customer("A", "Student"), new Goods(101, "Book1", "Textbook"), new OrderDetails(50, 20));
            Order order2 = new Order(10002, 1260, new Customer("B", "Teacher"), new Goods(102, "Book2", "Textbook"), new OrderDetails(60, 21));
            Order order3 = new Order(10003, 1540, new Customer("C", "Officer"), new Goods(103, "Book3", "Novels"), new OrderDetails(70, 22));
            //添加订单
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
            orderService.OutOrderList();
            orderService.AddOrder(order1); //error

            //删除订单
            orderService.DeleteOrder(order1);
            orderService.OutOrderList();
            orderService.DeleteOrder(order1); //error

            //修改订单
            order2.UpdateOrderPrice(1010);
            order2.UpdateOrderCustomer(new Customer("D", "Student"));
            order2.UpdateOrderGoods(new Goods(104, "Book2", "Notebook"));
            orderService.UpdateOrder(order2);
            orderService.OutOrderList();
            orderService.UpdateOrder(order1); //error

            //查询订单
            int[] ID = { 10003, 10004, 10002 };
            orderService.SearchByID(ID);
            string[] GoodsName = { "Book1" };
            orderService.SearchByGoods(GoodsName);
            string[] CustomerName = { "A", "C" };
            orderService.SearchByCustomer(CustomerName);
            double[] Price = { 1010, 1540, 1600 };
            orderService.SearchByPrice(Price);

            //排序
            orderService.OrderOrder();
            orderService.OutOrderList();
            orderService.OrderOrder(o => o.GetPrice());
            orderService.OutOrderList();
        }
    }
}
