using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.Linq;

namespace pragrimtech_c_sharp__vs_2019_
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList)
        {
            // what if company x wants to promote an employee under different
            // business rules, we can't change this at is hard coded
            foreach (Employee employee in employeeList)
            {
                if (employee.Experience >= 5)
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }

    }


    public class Program
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5},
                new Employee() { ID = 101, Name = "Mike", Salary = 4000, Experience = 4},
                new Employee() { ID = 101, Name = "John", Salary = 6000, Experience = 5},
                new Employee() { ID = 101, Name = "Todd", Salary = 3000, Experience = 3}
            };

            Employee.PromoteEmployee(employees);
        }

    }



}



