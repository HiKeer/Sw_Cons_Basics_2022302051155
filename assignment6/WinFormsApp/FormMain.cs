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

namespace WinFormsApp
{
    public partial class FormMain : Form
    {
        OrderService orderService = new OrderService();
        public string QueryText { get; set; }
        public FormMain()
        {
            InitializeComponent();
            InitOrders();
            BinOrderSrc.DataSource = orderService.GetAllOrders();
            查询textBox.DataBindings.Add("Text", this, "QueryText");
        }

        public void InitOrders()
        {
            Order order = new Order(1, new Customer("1", "李"), new List<OrderDetail>());
            order.AddItem(new OrderDetail(1, new Goods("1", "苹果", 100.0), 10));
            order.AddItem(new OrderDetail(2, new Goods("2", "鸡蛋", 50.0), 61));
            orderService.AddOrder(order);
            Order order2 = new Order(2, new Customer("2", "张"), new List<OrderDetail>());
            order2.AddItem(new OrderDetail(1, new Goods("2", "鸡蛋", 200.0), 10));
            orderService.AddOrder(order2);
        }

        private void 查询订单_Click(object sender, EventArgs e)
        {
            switch (查询comboBox.SelectedItem.ToString())
            {
                case "所有订单":
                    BinOrderSrc.DataSource = orderService.GetAllOrders();
                    break;
                case "订单号":
                    int id = Convert.ToInt32(QueryText);
                    List<Order> result = new List<Order>();
                    Order temporder = orderService.GetOrder(id);
                    if (temporder != null) result.Add(temporder);
                    BinOrderSrc.DataSource = result;
                    break;
                case "客户名":
                    BinOrderSrc.DataSource = orderService.QueryOrdersByCustomerName(QueryText);
                    break;
                case "货物名":
                    BinOrderSrc.DataSource = orderService.QueryOrdersByGoodsName(QueryText);
                    break;
                case "订单总价":
                    float price = Convert.ToSingle(QueryText);
                    BinOrderSrc.DataSource = orderService.QueryByTotalAmount(price);
                    break;
            }

        }
        public void QueryAllOrdersAfterDelete()
        {
            BinOrderSrc.DataSource = orderService.GetAllOrders();
            BinOrderSrc.ResetBindings(false);
        }

        private void 删除订单_Click(object sender, EventArgs e)
        {
            Order order = BinOrderSrc.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            DialogResult result = MessageBox.Show($"确认要删除Id为{order.OrderId}的订单吗？", "删除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                orderService.RemoveOrder(order.OrderId);
                QueryAllOrdersAfterDelete();
            }
        }

        private void UpdateOrderServiceData(OrderService newOrderService)
        {
            orderService = newOrderService; // 更新父窗口的 OrderService 属性
            BinOrderSrc.DataSource = null;
            BinDetailSrc.DataSource = null;
            BinOrderSrc.DataSource = orderService.GetAllOrders();
            BinDetailSrc.DataMember = "Details";
            BinDetailSrc.DataSource = BinOrderSrc;
        }

        private void OpenChildForm()
        {
            FormAdd formAdd = new FormAdd(new Order(), false, orderService);
            formAdd.UpdateOrderService += UpdateOrderServiceData; // 将子窗口的委托与父窗口的方法绑定
            formAdd.Show();
        }

        private void 创建订单_Click(object sender, EventArgs e)
        {
            OpenChildForm();
        }

        private void 修改订单_Click(object sender, EventArgs e)
        {
            OpenChildForm();
        }
    }
}