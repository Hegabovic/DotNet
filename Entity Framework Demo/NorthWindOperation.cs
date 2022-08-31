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
    public partial class NorthWindOperation : Form
    {
        NorthwindEntities nw = new NorthwindEntities();
        public NorthWindOperation()
        {
            InitializeComponent();
            lbCustomers.DataSource = nw.Customers.Select( c => c.CustomerID ).ToList();
            compoEmployees.DataSource = nw
                .Employees.Select(emp => new { FullName = emp.FirstName + " " + emp.LastName , emp.EmployeeID})
                .ToList();
            compoEmployees.DisplayMember = "FullName";
            compoEmployees.ValueMember = "EmployeeID";

            lbProduct.DataSource = nw.Products.Select( p => p.ProductName).ToList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lastOrderForCurrentCustomer = nw.Customers.Single(c => c.CustomerID == lbCustomers.SelectedValue.ToString())
                .Orders.Last().OrderID;
            Order_Detail od = new Order_Detail()
            {
                OrderID = lastOrderForCurrentCustomer,
                ProductID = nw.Products.Single(p => p.ProductName == lbProduct.SelectedValue.ToString()).ProductID,
                UnitPrice = decimal.Parse(unitprice.Text.ToString()),
                Quantity = short.Parse(quantity.Text.ToString()),
            };
            nw.Order_Details.Add(od);
            int isInserted = nw.SaveChanges();
            if (isInserted > 0)
            {
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something Went Wrong", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lbCustomers 
            lbNumberOfOrders.Text = nw.Customers
                                            .Single(c => c.CustomerID == lbCustomers.SelectedValue.ToString())
                                            .Orders.Count.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomersOrders co = new CustomersOrders(lbCustomers.SelectedValue.ToString());
            co.ShowDialog();    
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmployeeDetails ed = new EmployeeDetails(int.Parse(compoEmployees.SelectedValue.ToString()));
            ed.ShowDialog();
        }

        private void lbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            // selected index changed for lb product 
            var targetProduct = nw.Products.Single(p => p.ProductName == lbProduct.SelectedValue.ToString());
            unitprice.Text = targetProduct.UnitPrice.ToString();
            quantity.Text = targetProduct.QuantityPerUnit.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create order object (customer id , employee id , date )
            var targetCustomer = lbCustomers.SelectedValue.ToString();
            var targetEmployee = int.Parse(compoEmployees.SelectedValue.ToString());
            Order newOrder = new Order() { CustomerID = targetCustomer , EmployeeID = targetEmployee , OrderDate = monthCalendar.SelectionRange.Start};
            nw.Orders.Add(newOrder);  // just added in memory 
            int isInserted = nw.SaveChanges();
            if (isInserted > 0 ) 
            {
                lbCustomers_SelectedIndexChanged(null, null);
                MessageBox.Show("Added Successfully","Success", MessageBoxButtons.OK , MessageBoxIcon.Information); 
            }
            else
            {
                MessageBox.Show("Something Went Wrong", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
