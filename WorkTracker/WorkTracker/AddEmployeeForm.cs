using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTracker
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
            TBEmployeeNumber.Text = (Employee.employeeNumber + 1).ToString();
        }

        public List<Employee> Add()
        {
            Employee e = new Employee(Convert.ToInt32(TBEmployeeNumber.Text), TBEmployeeName.Text, TBEmployeePhone.Text);
            Employee.EmployeeList.Add(e);
            Employee.employeeNumber++;
            return Employee.EmployeeList;
        }

        private void ButtonAddEmployee_Click(object sender, EventArgs e)
        {
            Add();
            TBEmployeeNumber.Text = (Employee.employeeNumber + 1).ToString();
            TBEmployeeName.Clear();
            TBEmployeePhone.Clear();
            
        }

        private void ButtonDoneAdding_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
