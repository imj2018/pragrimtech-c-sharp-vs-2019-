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
public class PartTimeEmployee : Employee
{
    public new void PrintFullName()
    {
        //base.PrintFullName();
        Console.WriteLine(FirstName + " " + LastName + " - Contractor");
    }
}

public class FullTimeEmployee : Employee
{

}





namespace pragrimtech_c_sharp__vs_2019_
{
    class Pragim
    {
        public static void Main()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "FullTime";
            FTE.LastName = "Employee";
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            //Employee PTE = new PartTimeEmployee();
            PTE.FirstName = "PartTime";
            PTE.LastName = "Employee";
            PTE.PrintFullName();
            ((Employee)PTE).PrintFullName();

        }
    }

}







