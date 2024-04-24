using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderApp
{

    /**
     * The service class to manage orders
     * */
    public class OrderService
    {

        //the order list
        private List<Order> orders;


        public OrderService()
        {
            orders = new List<Order>();
        }


        public List<Order> GetAllOrders()
        {
            return orders;
        }


        public Order GetOrder(int id)
        {
            return orders.Where(o => o.OrderId == id).FirstOrDefault();
        }

        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
                throw new ApplicationException($"添加错误: 订单{order.OrderId} 已经存在了!");
            orders.Add(order);
        }

        public void RemoveOrder(int orderId)
        {
            Order order = GetOrder(orderId);
            if (order != null)
            {
                orders.Remove(order);
            }
        }

        public List<Order> QueryOrdersByGoodsName(string goodsName)
        {
            var query = orders
                    .Where(order => order.Details.Exists(item => item.GoodsName == goodsName))
                    .OrderBy(o => o.TotalPrice);
            return query.ToList();
        }

        public List<Order> QueryOrdersByCustomerName(string customerName)
        {
            return orders
                .Where(order => order.CustomerName == customerName)
                .OrderBy(o => o.TotalPrice)
                .ToList();
        }

        public void UpdateOrder(Order newOrder)
        {
            Order oldOrder = GetOrder(newOrder.OrderId);
            if (oldOrder == null)
                throw new ApplicationException($"修改错误：订单 {newOrder.OrderId} 不存在!");
            orders.Remove(oldOrder);
            orders.Add(newOrder);
        }

        public void Export(String fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, orders);
            }
        }

        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach(order => {
                    if (!orders.Contains(order))
                    {
                        orders.Add(order);
                    }
                });
            }
        }

        public object QueryByTotalAmount(float amout)
        {
            return orders
               .Where(order => order.TotalPrice >= amout)
               .OrderByDescending(o => o.TotalPrice)
               .ToList();
        }

        public void AddDetail(OrderDetail detail, Order order)
        {
            foreach (Order o in orders) 
            { 
                if(order.OrderId == o.OrderId)
                {
                    o.Details.Add(detail);
                }
            }
        }

        public void ModifyOrder(Order existingOrder, string customerID, string customerName)
        {
            foreach (Order o in orders)
            {
                if(o.OrderId == existingOrder.OrderId)
                {
                    o.Customer.ID = customerID;
                    o.Customer.Name = customerName;
                }
            }
        }
       
        public void ModifyDetail(Order existingOrder, OrderDetail detail, OrderDetail orderDetail)
        {
            foreach (Order o in orders)
            {
                if (existingOrder.OrderId == o.OrderId)
                {
                    int index = o.Details.IndexOf(detail);
                    if (index != -1)
                    {
                        // 在指定位置替换元素
                        o.Details.Insert(index, orderDetail);
                        // 移除原来的元素
                        o.Details.RemoveAt(index + 1);
                    }
                }
            }
        }
    }
}
