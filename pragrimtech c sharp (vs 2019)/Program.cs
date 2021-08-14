using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.Linq;
using System.IO;

class Customer
{
    string _firstName;
    string _lastName;

    public Customer() : this("No FirstName Provided", "No LastName Provided")
    {
    }
    public Customer(string FirstName, string LastName)
    {
        this._firstName = FirstName;
        this._lastName = LastName;
    }

    public void PrintFullName()
    {
        Console.WriteLine("Full Name = {0}", this._firstName + " " + this._lastName);
    }

    ~Customer()
    {
        //Clean up code
    }
}

namespace pragrimtech_c_sharp__vs_2019_
{

    class Pragim
    {
        public static void Main()
        {
            //Customer C1 = new Customer("John", "Doe");
            Customer C1 = new Customer();
            C1.PrintFullName();
            
            Customer C2 = new Customer("John", "Doe");
            C2.PrintFullName();

        }

    }

}







