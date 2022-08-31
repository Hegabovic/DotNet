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
    public partial class EmployeeDetails : Form
    {
        NorthwindEntities nw = new NorthwindEntities();
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        public EmployeeDetails(int _employeeID)
        {
            InitializeComponent();
            lbEmployee.Text = nw.Employees.Single(emp => emp.EmployeeID == _employeeID).FirstName.ToString();
            dataGridView4.DataSource = nw.Employees.Where(emp => emp.EmployeeID == _employeeID)
                .Select(emp => new { emp.Address, emp.BirthDate, emp.City, emp.Country }).ToList();
        }

        private void Customers_Click(object sender, EventArgs e)
        {

        }

        private void lbCustomerName_Click(object sender, EventArgs e)
        {

        }
    }
}
