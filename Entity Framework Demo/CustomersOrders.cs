using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework_Demo
{
    public partial class CustomersOrders : Form
    {
        NorthwindEntities nw = new NorthwindEntities();
        public CustomersOrders()
        {
            InitializeComponent();
        }

        public CustomersOrders(string _customerName) 
        {
            InitializeComponent();
            lbCustomerName.Text = _customerName;
            dataGridView1.DataSource = nw.Customers.Single(c => c.CustomerID == _customerName)
                .Orders.Select( o => new {  o.EmployeeID , o.OrderDate , o.OrderID, o.Order_Details }).ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
