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
        // this will hide the parent method with the same name
        // this will be invoked not the parent
        // use the new keyword if hiding is intentional
        public new void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " Contractor");
            // call the base class method
            //base.PrintFullName();
        }
    }

    public class PartTimeEmployee : Employee
    {
        //
    }

    public class Program
    {
        public static void Main()
        {
            //FullTimeEmployee FTE = new FullTimeEmployee();
            // assign the child to a reference of parent, this will now call the PrintFullName of the parent
            // not the PartTimeEmployee method
            Employee FTE = new FullTimeEmployee();
            FTE.FirstName = "mr full time";
            FTE.LastName = "employee";

            // type case to convert to Employee 
            //((Employee)FTE).PrintFullName();


            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "mr part time";
            PTE.LastName = "employee";
            PTE.PrintFullName();

        }
    }
}



