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
            ��ѯtextBox.DataBindings.Add("Text", this, "QueryText");
        }

        public void InitOrders()
        {
            Order order = new Order(1, new Customer("1", "��"), new List<OrderDetail>());
            order.AddItem(new OrderDetail(1, new Goods("1", "ƻ��", 100.0), 10));
            order.AddItem(new OrderDetail(2, new Goods("2", "����", 50.0), 61));
            orderService.AddOrder(order);
            Order order2 = new Order(2, new Customer("2", "��"), new List<OrderDetail>());
            order2.AddItem(new OrderDetail(1, new Goods("2", "����", 200.0), 10));
            orderService.AddOrder(order2);
        }

        private void ��ѯ����_Click(object sender, EventArgs e)
        {
            switch (��ѯcomboBox.SelectedItem.ToString())
            {
                case "���ж���":
                    BinOrderSrc.DataSource = orderService.GetAllOrders();
                    break;
                case "������":
                    int id = Convert.ToInt32(QueryText);
                    List<Order> result = new List<Order>();
                    Order temporder = orderService.GetOrder(id);
                    if (temporder != null) result.Add(temporder);
                    BinOrderSrc.DataSource = result;
                    break;
                case "�ͻ���":
                    BinOrderSrc.DataSource = orderService.QueryOrdersByCustomerName(QueryText);
                    break;
                case "������":
                    BinOrderSrc.DataSource = orderService.QueryOrdersByGoodsName(QueryText);
                    break;
                case "�����ܼ�":
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

        private void ɾ������_Click(object sender, EventArgs e)
        {
            Order order = BinOrderSrc.Current as Order;
            if (order == null)
            {
                MessageBox.Show("��ѡ��һ����������ɾ��");
                return;
            }
            DialogResult result = MessageBox.Show($"ȷ��Ҫɾ��IdΪ{order.OrderId}�Ķ�����", "ɾ��", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                orderService.RemoveOrder(order.OrderId);
                QueryAllOrdersAfterDelete();
            }
        }

        private void UpdateOrderServiceData(OrderService newOrderService)
        {
            orderService = newOrderService; // ���¸����ڵ� OrderService ����
            BinOrderSrc.DataSource = null;
            BinDetailSrc.DataSource = null;
            BinOrderSrc.DataSource = orderService.GetAllOrders();
            BinDetailSrc.DataMember = "Details";
            BinDetailSrc.DataSource = BinOrderSrc;
        }

        private void OpenChildForm()
        {
            FormAdd formAdd = new FormAdd(new Order(), false, orderService);
            formAdd.UpdateOrderService += UpdateOrderServiceData; // ���Ӵ��ڵ�ί���븸���ڵķ�����
            formAdd.Show();
        }

        private void ��������_Click(object sender, EventArgs e)
        {
            OpenChildForm();
        }

        private void �޸Ķ���_Click(object sender, EventArgs e)
        {
            OpenChildForm();
        }
    }
}