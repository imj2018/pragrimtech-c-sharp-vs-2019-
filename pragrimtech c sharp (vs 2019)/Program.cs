using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.Linq;

namespace pragrimtech_c_sharp__vs_2019_
{

    /// <summary>
    // only declarations
    // interfaces cannot use access modifiers are public by default
    // cannot have fields
    // cannot have implementation details
    /// </summary>
    interface ICustomer1
    {
        //void Print();
        void Print1();

    }

    // inteface inheritance chain, the class i.e Customer must use all methods
    // i.e Print1 and Print2
    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }

    public class Sample
    {

    }

    // class must implement all methods
    // multi inteface inheritance
    public class Customer : ICustomer2
    {

        // signature must match
        //public void Print()
        public void Print1()
        {
            Console.WriteLine("Inteface Print1 Method");
        }
        public void Print2()
        {
            Console.WriteLine("Inteface Print2 Method");
        }

    }

    // to reiterate classes cannot have multiple inheritance
    //public class Program : Customer, Sample 
    public class Program
    {
        public static void Main()
        {
            // interface cannot be concrete
            //ICustomer1 Customer = new ICustomer1();

            // interfaces can be used as reference variables to point to a dervied class, ICustomer is essentially a parent of Customer
            // therefore can be inherited/derived from
            ICustomer1 Customer1 = new Customer();
            Customer1.Print1();

            // must use all methods from inheritance chain
            ICustomer2 Customer2 = new Customer();
            Customer2.Print1();
            Customer2.Print2();

        }
    }

}



