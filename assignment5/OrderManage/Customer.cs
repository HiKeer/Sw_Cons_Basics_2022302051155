using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    public class Customer //客户
    {
        private string Customer_name;
        private string Customer_description;
        public Customer(string Customer_name, string Customer_description)
        {
            this.Customer_name = Customer_name;
            this.Customer_description = Customer_description;
        }
        public string GetCustomerName() { return Customer_name; }
        public override string ToString() { return Customer_name + " " + Customer_description; }
    }
}
