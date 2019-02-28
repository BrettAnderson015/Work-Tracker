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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            LoadEmployees();

            List<string> newJobs = new List<string>();
            foreach(Job j in Job.JobList.Where(n => n.Status == "New"))
            {
                newJobs.Add(j.Name);
            }

            List<string> inProgressJobs = new List<string>();
            foreach (Job j in Job.JobList.Where(n => n.Status == "In Progress"))
            {
                inProgressJobs.Add(j.Name);
            }

            foreach (string s in newJobs)
            {
                CBDayOne.Items.Add(s);
                CBDayTwo.Items.Add(s);
                CBDayThree.Items.Add(s);
                CBDayFour.Items.Add(s);
                CBDayFive.Items.Add(s);
            }
            
            foreach(string s in inProgressJobs)
            {
                CBDayOne.Items.Add(s);
                CBDayTwo.Items.Add(s);
                CBDayThree.Items.Add(s);
                CBDayFour.Items.Add(s);
                CBDayFive.Items.Add(s);
            }
        }

        public void UpdateWorkAssignment()
        {
            if (string.IsNullOrEmpty(CBName.Text))
            {
                MessageBox.Show("Please select an employee.");
            }
            else
            {
                int nameIndex = Employee.EmployeeList.FindIndex(n => n.Name == CBName.Text);
                Employee.EmployeeList[nameIndex].DayOneAssignment = CBDayOne.Text;
                Employee.EmployeeList[nameIndex].DayTwoAssignment = CBDayTwo.Text;
                Employee.EmployeeList[nameIndex].DayThreeAssignment = CBDayThree.Text;
                Employee.EmployeeList[nameIndex].DayFourAssignment = CBDayFour.Text;
                Employee.EmployeeList[nameIndex].DayFiveAssignment = CBDayFive.Text;

                CBName.ResetText();
                CBDayOne.ResetText();
                CBDayTwo.ResetText();
                CBDayThree.ResetText();
                CBDayFour.ResetText();
                CBDayFive.ResetText();
            }
        }

        public void LoadCBNames()
        {
            CBName.Items.Clear();

            List<string> employeeNames = new List<string>();
            foreach (Employee e in Employee.EmployeeList)
            {
                employeeNames.Add(e.Name);
            }

            foreach (string s in employeeNames)
            {
                CBName.Items.Add(s);
            }
        }

        public void LoadEmployees()
        {
            var source = new BindingSource();
            source.DataSource = Employee.EmployeeList;
            DGVEmployees.DataSource = source;
        }

        public void CountManDays()
        {
            foreach (Job k in Job.JobList)
            {
                k.ManDays = 0;
            }
            for (int i = 0; i < Job.JobList.Count; i++)
            {
                for (int j = 0; j < Employee.EmployeeList.Count; j++)
                {
                    if (Employee.EmployeeList[j].DayOneAssignment == Job.JobList[i].Name)
                    {
                        Job.JobList[i].ManDays++;
                    }
                    if (Employee.EmployeeList[j].DayTwoAssignment == Job.JobList[i].Name)
                    {
                        Job.JobList[i].ManDays++;
                    }
                    if (Employee.EmployeeList[j].DayThreeAssignment == Job.JobList[i].Name)
                    {
                        Job.JobList[i].ManDays++;
                    }
                    if (Employee.EmployeeList[j].DayFourAssignment == Job.JobList[i].Name)
                    {
                        Job.JobList[i].ManDays++;
                    }
                    if (Employee.EmployeeList[j].DayFiveAssignment == Job.JobList[i].Name)
                    {
                        Job.JobList[i].ManDays++;
                    }
                }
            }
        }

        private void ButtonAddEmployeeForm_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.Show();
        }

        private void ButtonReturntoJob_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLoadAllEmployees_Click(object sender, EventArgs e)
        {
            LoadEmployees();
            LoadCBNames();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateWorkAssignment();
            LoadEmployees();
            CountManDays();
        }
    }
}
