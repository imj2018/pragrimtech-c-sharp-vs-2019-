using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.Linq;

namespace pragrimtech_c_sharp__vs_2019_
{

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        // pass the delegate as a parameter, at runtime the delegate will invoke the method IsPromotable
        // is pointing to
        // essentially this function is taking a another function as a parameter (when you want
        // to pass a function as a paramter think of delegates

        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable isPromotable)
        {
            foreach (Employee employee in employeeList)
            {
                // instead of hard coding the logic, it can be decoupled
                // condition returns a bool and should match the delegate and will be replaced by
                // a delegate
                //if (employee.Experience >= 5)
                // the logic to promote will now be decided by the end user
                if (isPromotable(employee))
                {
                    Console.WriteLine(employee.Name + " promoted");
                }
            }
        }
    }

    // delegate will return a true or false for an Employee passed in
    public delegate bool IsPromotable(Employee employee);


    public class Program
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { ID = 101, Name = "Mary", Salary = 5000, Experience = 5},
                new Employee() { ID = 102, Name = "Mike", Salary = 4000, Experience = 4},
                new Employee() { ID = 103, Name = "John", Salary = 6000, Experience = 5},
                new Employee() { ID = 104, Name = "Todd", Salary = 3000, Experience = 3}
            };

            // to reiterate a delegate is like a class, when an instance is created the constructor accepts the
            // name of the function and the signature must match
            // pass the function to the constructor of the delegate, no brackets Promote()
            //IsPromotable isPromotable = new IsPromotable(Promote);

            // this now takes another parameter which is the delegate
            //Employee.PromoteEmployee(employees, isPromotable);

            // delegates can add more difficulty
            // a lambda can be used instead (lambda expressions are based on delegates) 
            // it will operate on an employee object
            // employee such that an employee experience >= 5
            // behind the scenes it operates the same as a delegate
            Employee.PromoteEmployee(employees, employee => employee.Experience >= 5);
        }


        // the logic is now outside 
        //public static bool Promote(Employee employee)
        //{
        //    if (employee.Experience >= 5)
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



