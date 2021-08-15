using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.Linq;
using System.IO;

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

public class TemporaryEmpoyee : Employee
{
    //public override void PrintFullName()
    //{
    //    Console.WriteLine(FirstName + " " + LastName + " - Temporary");
    //}
}

namespace pragrimtech_c_sharp__vs_2019_
{
    class Pragim
    {
        public static void Main()
        {
            // "polymorphism allows us to invoke derived class methods
            // using a base class variable at run time"
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee());
            employees.Add(new PartTimeEmployee());
            employees.Add(new FullTimeEmployee());
            employees.Add(new TemporaryEmpoyee());

            for (int i = 0; i < employees.Count; i++)
            {
                employees[i].PrintFullName();
            }

        }
    }

}







