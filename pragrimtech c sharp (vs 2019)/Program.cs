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

        // PrintFullName will only be called from the parent unless the base is marked
        //  as virtual, this indicates to derived classes that they can override base implementation
        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        //public void PrintFullName()
        //{
        //    Console.WriteLine(FirstName + " " + LastName + " - Part Time");
        //}

        // can type override space and it will show via intellisense
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
            // polymorphism allows you to invoke derived class methods using a base class reference
            // variables at runtime i.e Employee as the base class variable with a PrintFullName method but using
            // PartTimeEmployee's derived class PrintFullName method instead 

            // to reiterate a base class variable can point to a child object i.e the array is of type
            // Employee with child elements
            // even though each derived class has its own PrintFullName i.e hidden, the variable is the 
            // parent class therefore it will use the parent method therefore needs to be overriden
            //
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



