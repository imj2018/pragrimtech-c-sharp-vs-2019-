using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;


namespace pragrimtech_c_sharp__vs_2019_
{
    interface ICustomer1
    {
        void Print1();
    }

    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }

    public class Customer : ICustomer2
    {
        // must use all implementations in chain inheritance chain
        public void Print1()
        {
            Console.WriteLine("Print1");
        }

        public void Print2()
        {
            Console.WriteLine("Print2");
        }
    }


    interface Interface1
    {
        // C# no fields
        //int ID;

        void Print();
        void Print(string message);
    }

    interface Interface2
    {
        void Interface2Method();
    }

    // multiple interfaces
    public class Sample : Interface1, Interface2
    {

        public void Print()
        {
            Console.WriteLine("Interface Print Method");
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public void Interface2Method()
        {
            throw new NotImplementedException();
        }
    }

    //public class Sample
    //{
    //    //
    //}

    //public class Program : Test, Sample
    public class Program : Sample
    {
        public static void Main()
        {
            Sample sample = new Sample();
            sample.Print();
            sample.Print("homicidal");

            //ICustomer1 cust = new Customer();
            // it can be used a reference variable as ICustomer1 is a parent
            // and can point to a Customer object
            ICustomer1 cust = new Customer();
            cust.Print1();
        }
    }
}



