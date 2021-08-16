using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;


namespace pragrimtech_c_sharp__vs_2019_
{
    // cannot be instatiated, can only be a base class
    // for other classes
    public abstract class Customer
    {
        //public abstract void Print();
        public void Print()
        {
            Console.WriteLine("Print");
        }

    }

    public class Program : Customer
    //public abstract class Program : Customer
    {
        //public override void Print()
        //{
        //    Console.WriteLine("Print Method");
        //}
        public static void Main()
        {
            //Program P = new Program();
            // as an abstract parent class can point to derived class object
            Customer C = new Program();
            C.Print();

        }


    }
}



