using OrderApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp
{
    public partial class FormAdd : Form
    {
        private OrderService AddFormOrderService;
        public int orderID;
        public string customerID;
        public string customerName;
        public int inDex;
        public string goodsID;
        public string goodsName;
        public double goodsPrice;
        public int quantity;
        public bool IsAdd = true;
        public bool IsAddDetail = true;
        public bool IsModify = true;
        public bool IsOrderExist = false;
        public string QueryText1 { get; set; }
        public string QueryText4 { get; set; }
        public string QueryText7 { get; set; }
        public string QueryText8 { get; set; }

        public delegate void UpdateOrderServiceDelegate(OrderService newOrderService);
        public event UpdateOrderServiceDelegate UpdateOrderService;


        public FormAdd(Order order, bool model, OrderService orderService)
        {
            InitializeComponent();
            AddFormOrderService = orderService;
            BinOrderSrc.DataSource = orderService.GetAllOrders();
            textBox1.DataBindings.Add("Text", this, "QueryText1");
            textBox4.DataBindings.Add("Text", this, "QueryText4");
            textBox7.DataBindings.Add("Text", this, "QueryText7");
            textBox8.DataBindings.Add("Text", this, "QueryText8");
        }

        private void 创建订单_Click(object sender, EventArgs e)
        {
            orderID = Convert.ToInt32(QueryText1);
            customerID = textBox2.Text;
            customerName = textBox3.Text;
            Order order = new Order(orderID, new Customer(customerID, customerName), new List<OrderDetail>());
            List<Order> orderList = AddFormOrderService.GetAllOrders();
            foreach (Order existingOrder in orderList)
            {
                if (existingOrder.OrderId == orderID)
                {
                    IsAdd = false;
                    MessageBox.Show("订单已存在，无法重复添加");
                }
            }
            if (IsAdd) { AddFormOrderService.AddOrder(order); }
            UpdateOrderService?.Invoke(AddFormOrderService);
        }

        private void 添加明细_Click(object sender, EventArgs e)
        {
            orderID = Convert.ToInt32(QueryText1);
            customerID = textBox2.Text;
            customerName = textBox3.Text;
            Order order = new Order(orderID, new Customer(customerID, customerName), new List<OrderDetail>());
            inDex = Convert.ToInt32(QueryText4);
            goodsID = textBox5.Text;
            goodsName = textBox6.Text;
            goodsPrice = Convert.ToDouble(QueryText7);
            quantity = Convert.ToInt32(QueryText8);
            Goods goods = new Goods(goodsID, goodsName, goodsPrice);
            OrderDetail orderDetail = new OrderDetail(inDex, goods, quantity);
            List<Order> orderList = AddFormOrderService.GetAllOrders();
            List<OrderDetail> orderDetailList = new List<OrderDetail>();
            foreach (Order existingOrder in orderList)
            {
                if (existingOrder.OrderId == orderID)
                {
                    IsOrderExist = true;
                    orderDetailList = existingOrder.Details;
                }
            }
            if (IsOrderExist)
            {
                foreach (OrderDetail detail in orderDetailList)
                {
                    if (detail.Index == inDex)
                    {
                        IsAddDetail = false;
                        MessageBox.Show("明细已存在，无法重复添加");
                    }
                }
                if (IsModify)
                {
                    AddFormOrderService.AddDetail(orderDetail, order);
                }

                UpdateOrderService?.Invoke(AddFormOrderService);
            }
            else
            {
                MessageBox.Show("未找到该订单");
            }
        }

        private void 修改订单_Click(object sender, EventArgs e)
        {
            orderID = Convert.ToInt32(QueryText1);
            customerID = textBox2.Text;
            customerName = textBox3.Text;
            Order order = new Order(orderID, new Customer(customerID, customerName), new List<OrderDetail>());
            inDex = Convert.ToInt32(QueryText4);
            goodsID = textBox5.Text;
            goodsName = textBox6.Text;
            goodsPrice = Convert.ToDouble(QueryText7);
            quantity = Convert.ToInt32(QueryText8);
            Goods goods = new Goods(goodsID, goodsName, goodsPrice);
            OrderDetail orderDetail = new OrderDetail(inDex, goods, quantity);
            List<Order> orderList = AddFormOrderService.GetAllOrders();
            List<OrderDetail> detailsToUpdate = new List<OrderDetail>();
            foreach (Order existingOrder in orderList)
            {
                if (existingOrder.OrderId == orderID)
                {
                    IsOrderExist = true;
                    AddFormOrderService.ModifyOrder(existingOrder, customerID, customerName);
                    foreach (OrderDetail detail in existingOrder.Details)
                    {
                        if (detail.Index == inDex)
                        {
                            // 将需要修改的元素添加到临时集合中
                            detailsToUpdate.Add(detail);
                        }
                    }
                    foreach (OrderDetail detail in detailsToUpdate)
                    {
                        if (detail.Index == inDex)
                        {
                            AddFormOrderService.ModifyDetail(existingOrder, detail, orderDetail);
                        }
                    }

                    UpdateOrderService?.Invoke(AddFormOrderService);
                }
            }
            if (!IsOrderExist)
            {
                MessageBox.Show("未找到该订单");
            }
        }
    }
}
