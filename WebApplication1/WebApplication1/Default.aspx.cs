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

            //  .NET can detect the indexer when using square brackets [
            Response.Write("Name of Employee With Id = 2: " + company[2]);
            Response.Write("<br />");
            Response.Write("Name of Employee With Id = 5: " + company[5]);
            Response.Write("<br />");
            Response.Write("Name of Employee With Id = 8: " + company[8]);
            Response.Write("<br />");

            Response.Write("Changing names of employees with Id = 2, 5 & 8 ");
            Response.Write("<br />");
            Response.Write("<br />");

            //  using set to change the values
            company[2] = "2nd Employee name Changed";
            company[5] = "5th Employee name Changed";
            company[8] = "8th Employee name Changed";

            Response.Write("Name of Employee With Id = 2: " + company[2]);
            Response.Write("<br />");
            Response.Write("Name of Employee With Id = 5: " + company[5]);
            Response.Write("<br />");
            Response.Write("Name of Employee With Id = 8: " + company[8]);
            Response.Write("<br />");

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

        //  when a Company object is created so is a List of Employees
        //  
        //  would likely load a list of employees from a db in reality
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

        //Company[3] = "Jade";

        //  indexer implementation
        //
        //  retrieve the employees using the EmployeeID, while using the employeeID indexer
        //  change the name of the employees 
        //
        //  return type is string for the Name, an indexer is reated using this keyword,
        //  the indexer syntax is this[int employeeID]
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