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
        public string FirstName = "FN";
        public string LastName = "LN";

     
        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Part Time");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Full Time");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Temporary Time");
        }

    }

    public class Program
    {
        public static void Main()
        {
            Employee[] employees = new Employee[4]
            {
                //employees[0] = new Employee(),
                //employees[1] = new PartTimeEmployee(),
                //employees[2] = new FullTimeEmployee(),
                //employees[3] = new TemporaryEmployee()

                new Employee(),
                new PartTimeEmployee(),
                new FullTimeEmployee(),
                new TemporaryEmployee()
            };

            foreach (Employee employee in employees)
            {
                employee.PrintFullName();
            }


        }
    }
}



