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
    public partial class AddJob : Form
    {
        public AddJob()
        {
            InitializeComponent();
            TBNumber.Text = (Job.JobList.Count() + 1).ToString();
            CBStatus.Items.Add("New");
            CBStatus.Items.Add("In Progress");
            CBStatus.Items.Add("Complete");
            CBStatus.Text = "New";
        }

        public List<Job> Add()
        {
            Job j = new Job(Convert.ToInt32(TBNumber.Text), TBName.Text, TBDescription.Text, TBLocation.Text, TBCustomer.Text, CBStatus.Text, TBNotes.Text);
            Job.JobList.Add(j);
            return Job.JobList;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Add();
            TBNumber.Text = (Job.JobList.Count() + 1).ToString();
            TBName.Clear();
            TBDescription.Clear();
            TBLocation.Clear();
            TBCustomer.Clear();
            TBNotes.Clear();
        }

        private void ButtonCloseAddJob_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
