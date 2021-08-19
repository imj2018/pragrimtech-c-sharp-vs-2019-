using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();

            //  use indexer to change employee with ID of 2 to Mark
            //company[2] = "Mark";

            Response.Write("Before Update");
            Response.Write("<br />");

            //  get total number of male employees using an indexer
            //  using the get accessor of the indexer
            Response.Write("Total Male Employees = " + company["Male"]);
            Response.Write("<br />");
            Response.Write("Total Female Employees = " + company["Female"]);

            Response.Write("<br />");
            Response.Write("<br />");

            // using the set accessor
            company["Male"] = "Female";
            Response.Write("After Update");
            Response.Write("<br />");
            Response.Write("Total Male Employees = " + company["Male"]);
            Response.Write("<br />");
            Response.Write("Total Female Employees = " + company["Female"]);

        }

    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class Company
    {
        private List<Employee> employees;

        public Company()
        {
            employees = new List<Employee>()
            {
                new Employee() { EmployeeId = 1, Name = "Mike", Gender = "Male" },
                new Employee() { EmployeeId = 2, Name = "Pam", Gender = "Female" },
                new Employee() { EmployeeId = 3, Name = "John", Gender = "Male" },
                new Employee() { EmployeeId = 4, Name = "Maxine", Gender = "Female" },
                new Employee() { EmployeeId = 5, Name = "Emiliy", Gender = "Female" },
                new Employee() { EmployeeId = 6, Name = "Scott", Gender = "Male" },
                new Employee() { EmployeeId = 7, Name = "Todd", Gender = "Male" },
                new Employee() { EmployeeId = 8, Name = "Ben", Gender = "Male" }
            };
        }


        //  "Company class has got only one indexer with one parameter which is 
        //  of type integer"
        public string this[int employeeID]
        {
            get
            {
                return employees.FirstOrDefault(emp => emp.EmployeeId == employeeID).Name;
            }
            set
            {
                employees.FirstOrDefault(emp => emp.EmployeeId == employeeID).Name = value;
            }
        }

        // overloading indexer
        public string this[string gender]
        {
            get
            {
                //  Count returns an integer so a cast to string is needed
                return employees.Count(emp => emp.Gender == gender).ToString();
            }
            set
            {
                foreach (Employee employee in employees)
                {
                    if (employee.Gender == gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }

    }
   










    public interface IEmployee
    {
        void EmployeeMethod();
    }

    public interface ICustomer
    {
        void CustomerMethod();

    }


}