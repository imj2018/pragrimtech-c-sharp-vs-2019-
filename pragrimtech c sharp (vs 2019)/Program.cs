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
    public string FirstName;
    public string LastName;
    public string Email;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmployee : Employee
{
    public float YearlySalary;

}

public class PartTimeEmployee : Employee
{
    public float HourlyRate;
}

public class A : PartTimeEmployee
{

}

public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("Parent Constructor called");
    }

    public ParentClass(string Message)
    {
        Console.WriteLine(Message);
    }
}

public class ChildClass : ParentClass
{
    public ChildClass() : base("Derived class controlling Parent Class")
    {
        Console.WriteLine("ChildClass Constructor called");
    }
}


namespace pragrimtech_c_sharp__vs_2019_
{
    class Pragim
    {
        public static void Main()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "John";
            FTE.LastName = "Doe";
            FTE.YearlySalary = 5000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Part";
            PTE.LastName = "Time";
            PTE.HourlyRate = 30.00f;
            PTE.PrintFullName();

            A A1 = new A();
            A1.FirstName = "multi level class inheritance, derived from PartTimeEmployee";
            A1.HourlyRate = 30.00f;
            A1.PrintFullName();

            ChildClass CC = new ChildClass();

        }
    }

}







