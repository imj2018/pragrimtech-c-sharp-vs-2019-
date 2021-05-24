using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;



namespace pragrimtech_c_sharp__vs_2019_
{

    // when a child/derived object is created a base class instance is created first
    // the constructor of the base class is called first
    // e.g PrintFullName() is an instance member (not static) of the base class 
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass Constructor called");
        }

        public ParentClass(string Message)
        {
            Console.WriteLine(Message);
        }
    }

    public class ChildClass : ParentClass
    {
        // to choose the constructor from the parent the base keyword can be used
        // intellisense will show whih constructor to choose from
        public ChildClass() : base("Derived class controlling Parent class constructor called")
        {
            Console.WriteLine("ChildClass Constructor called");
        }
    }

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

    // analogy like derived class is comparitive to a general surgeon to specialized doctor,
    // at times can e.g a gynecologist can do there gynocology things but also perform general surgery  
    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }

    // only single class inheritance allowed
    //public class PartTimeEmployee : Employee, A
    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }

    // multilevel class inheritance
    // class A will have the code from PartTimeEmployee and Employee
    public class A : PartTimeEmployee
    {

    }

    class Program
    {
        public static void Main()
        {

            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Pragim";
            FTE.LastName = "Tech";
            FTE.PrintFullName();
            FTE.YearlySalary = 50000;

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Partime";
            PTE.LastName = "Guy";
            PTE.PrintFullName();
            PTE.HourlyRate = 40;

            A A1 = new A();
            A1.FirstName = "multi";
            A1.HourlyRate = 40;

            ChildClass CC = new ChildClass();

        }
    }
}



