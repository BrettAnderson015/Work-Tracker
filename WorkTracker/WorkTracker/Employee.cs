using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTracker
{
    public class Employee
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string DayOneAssignment { get; set; }
        public string DayTwoAssignment { get; set; }
        public string DayThreeAssignment { get; set; }
        public string DayFourAssignment { get; set; }
        public string DayFiveAssignment { get; set; }

        public Employee(int number, string name, string phone)
        {
            Number = number;
            Name = name;
            Phone = phone;
        }

        public Employee() { }

        public static List<Employee> EmployeeList = new List<Employee>();

        public static int employeeNumber;
    }
}
