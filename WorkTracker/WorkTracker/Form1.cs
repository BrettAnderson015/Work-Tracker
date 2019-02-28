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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CBJobStatus.Items.Add("New");
            CBJobStatus.Items.Add("In Progress");
            CBJobStatus.Items.Add("Complete");
            CBJobStatus.Items.Add("All");
            CBJobStatus.Text = "All";
            DGVJobs.CellClick += new DataGridViewCellEventHandler(DGVCellClick);
        }

        void DGV()
        {
             
            var source = new BindingSource();
            source.DataSource = Job.JobList;
            DGVJobs.DataSource = source;

            List<Job> NewJobsList = new List<Job>();
            var newJobs = Job.JobList.Where(j => j.Status == "New");
            foreach(Job j in newJobs)
            {
                NewJobsList.Add(j);
            }

            List<Job> InProgressJobsList = new List<Job>();
            var inProgressJobs = Job.JobList.Where(j => j.Status == "In Progress");
            foreach (Job j in inProgressJobs)
            {
                InProgressJobsList.Add(j);
            }

            List<Job> CompleteJobsList = new List<Job>();
            var completeJobs = Job.JobList.Where(j => j.Status == "Complete");
            foreach (Job j in completeJobs)
            {
                CompleteJobsList.Add(j);
            }

            switch (CBJobStatus.Text)
            {
                case "New":
                    source.DataSource = NewJobsList;
                    break;
                case "In Progress":
                    source.DataSource = InProgressJobsList;
                    break;
                case "Complete":
                    source.DataSource = CompleteJobsList;
                    break;
                default:
                    source.DataSource = Job.JobList;
                    break;
            }
        }

        private void DGVCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex > -1)
            {
                DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();

                if (DGVJobs.Columns[e.ColumnIndex].Name.Contains("Status"))
                {
                    DGVJobs[e.ColumnIndex, e.RowIndex] = comboBoxCell;
                    List<string> Statuses = new List<string>();
                    Statuses.Add("New");
                    Statuses.Add("In Progress");
                    Statuses.Add("Complete");
                    comboBoxCell.DataSource = Statuses;
                }
            }
        }

        private void ButtonAddJob_Click_1(object sender, EventArgs e)
        {
            AddJob addJob = new AddJob();
            addJob.Show();
        }

        private void ButtonLoadAll_Click(object sender, EventArgs e)
        {
            DGV();
        }

        private void ButtonEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeform = new EmployeeForm();
            employeeform.Show();
        }

        private void CBJobStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGV();
        }
    }
}
