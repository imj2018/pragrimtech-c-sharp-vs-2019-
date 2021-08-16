using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;


namespace pragrimtech_c_sharp__vs_2019_
{



    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        // think of delegates when wanting to pass a function as a parameter
        public static void PromoteEmployee(List<Employee> employeeList,
            IsPromotableDelegate isPromotable)
        {
            foreach(Employee employee in employeeList)
            {
                if(isPromotable(employee))
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }

    }

    public delegate bool IsPromotableDelegate(Employee employee);

    public class Program
    {
        public static void Main()
        {
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee() { Id = 101, Name = "Mary", Salary = 5000, Experience = 5},
                new Employee() { Id = 102, Name = "Mike", Salary = 4000, Experience = 4},
                new Employee() { Id = 103, Name = "John", Salary = 6000, Experience = 6},
                new Employee() { Id = 104, Name = "Todd", Salary = 3000, Experience = 3}
            };

            //IsPromotableDelegate isPromotable = new IsPromotableDelegate(Promote);

            //Employee.PromoteEmployee(employeeList, isPromotable);
            // lambda instead, employee such that employee.Experience >= 5 
            Employee.PromoteEmployee(employeeList, employee => employee.Experience >= 5);


        }

        // logic is in the delegate and can be passed as a parameter to 
        // a function
        //public static bool Promote(Employee employee)
        //{
        //    if(employee.Experience >= 5)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}



