using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderApp
{
    public class OrderService
    {

        public OrderService() 
        {
            using (var ctx = new MYSQL()) { }
        }

        public List<Order> GetAllOrders()
        {
            using (var ctx = new MYSQL())
            {
                return ctx.Orders
                    .ToList<Order>();
            }
        }


        public Order GetOrder(int id)
        {
            using (var ctx = new MYSQL())
            {
                return ctx.Orders.Where(o => o.OrderId == id).FirstOrDefault();
            }
        }

        //避免级联添加或修改Customer和Goods
        private static void FixOrder(Order newOrder)
        {
            newOrder.CustomerId = newOrder.Customer.Id;
            newOrder.Customer = null;
            newOrder.Details.ForEach(d => {
                d.GoodsId = d.GoodsItem.Id;
                d.GoodsItem = null;
            });
        }
        public void AddOrder(Order order)
        {
            FixOrder(order);
            using (var ctx = new MYSQL())
            {
                ctx.Entry(order).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public void RemoveOrder(int orderId)
        {
            using (var ctx = new MYSQL())
            {
                Order order = GetOrder(orderId);
                if (order == null) return;
                ctx.OrderDetails.RemoveRange(order.Details);
                ctx.Orders.Remove(order);
                ctx.SaveChanges();
            }
        }

        public List<Order> QueryOrdersByGoodsName(string goodsName)
        {
            using (var ctx = new MYSQL())
            {
                var query = ctx.Orders
                    .Where(order => order.Details.Exists(item => item.GoodsName == goodsName))
                    .OrderBy(o => o.TotalPrice);
                return query.ToList();
            }
        }

        public List<Order> QueryOrdersByCustomerName(string customerName)
        {
            using (var ctx = new MYSQL())
            {
                return ctx.Orders
                .Where(order => order.CustomerName == customerName)
                .OrderBy(o => o.TotalPrice)
                .ToList();
            }
        }

        public void UpdateOrder(Order newOrder)
        {
            using (var ctx = new MYSQL())
            {
                Order oldOrder = GetOrder(newOrder.OrderId);
                if (oldOrder == null)
                    throw new ApplicationException($"修改错误：订单 {newOrder.OrderId} 不存在!");
                ctx.Orders.Remove(oldOrder);
                ctx.Orders.Add(newOrder);
            }
        }

        public void Export(String fileName)
        {
            using (var ctx = new MYSQL())
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    xs.Serialize(fs, ctx.Orders);
                }
            }
        }

        public void Import(string path)
        {
            using (var ctx = new MYSQL())
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    List<Order> temp = (List<Order>)xs.Deserialize(fs);
                    temp.ForEach(order =>
                    {
                        if (!ctx.Orders.Contains(order))
                        {
                            ctx.Orders.Add(order);
                        }
                    });
                }
            }
        }

        public object QueryByTotalAmount(float amout)
        {
            using (var ctx = new MYSQL())
            {
                return ctx.Orders
               .Where(order => order.TotalPrice >= amout)
               .OrderByDescending(o => o.TotalPrice)
               .ToList();
            }
        }

        public void AddDetail(OrderDetail detail, Order order)
        {
            using (var ctx = new MYSQL())
            {
                foreach (Order o in ctx.Orders)
                {
                    if (order.OrderId == o.OrderId)
                    {
                        o.Details.Add(detail);
                    }
                }
            }
        }

        public void ModifyOrder(Order existingOrder, string customerID, string customerName)
        {
            using (var ctx = new MYSQL())
            {
                foreach (Order o in ctx.Orders)
                {
                    if (o.OrderId == existingOrder.OrderId)
                    {
                        o.Customer.Id = customerID;
                        o.Customer.Name = customerName;
                    }
                }
            }
        }

        public void ModifyDetail(Order existingOrder, OrderDetail detail, OrderDetail orderDetail)
        {
            using (var ctx = new MYSQL())
                foreach (Order o in ctx.Orders)
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

