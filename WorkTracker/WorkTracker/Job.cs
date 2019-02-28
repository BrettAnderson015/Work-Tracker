using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTracker
{
    public class Job
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Customer { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public int ManDays { get; set; }

        public Job(int number, string name, string description, string location, string customer, string status, string notes)
        {
            Number = number;
            Name = name;
            Description = description;
            Location = location;
            Customer = customer;
            Status = status;
            Notes = notes;
        }

        public Job() { }

        public static List<Job> JobList = new List<Job>();
    }   
}
