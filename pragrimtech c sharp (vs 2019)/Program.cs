using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;

namespace pragrimtech_c_sharp__vs_2019_
{
    class Customer
    {
        public string _firstName;
        public string _lastName;

        // default constructor that can be useful for no parameters
        public Customer() : this("No FirstName Provided", "No LastName Provided")
        {

        }

        // .net has a default constructor with no parameters (if no constructor is declared)
        // overloading constructors
        public Customer(string FirstName, string LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", this._firstName + " " + this._lastName);
        }

        // destructor, to manually clean up resources as opposed to garbage collector
        ~Customer()
        {

        }
    }
    class Program
    {
        public static void Main()
        {
            //Customer C1 = new Customer("Pragim", "Technologies");
            Customer C1 = new Customer();
            C1.PrintFullName();

            Customer C2 = new Customer("Joe", "Smith");
            C2.PrintFullName();

        }

    }

 }



