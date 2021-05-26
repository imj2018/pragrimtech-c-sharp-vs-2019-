using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;


namespace pragrimtech_c_sharp__vs_2019_
{

    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a Base Class Print Method");
        }
    }

    public class DerivedClass : BaseClass
    {
        //public override void Print()
        public new void Print() // hiding
        {
            Console.WriteLine("I am a Derived Class Print Method");
        }
    }

    public class Program
    {
        public static void Main()
        {
            // to reiterate a base class reference variable points to a derived class object
            // if  a method is overriden in the derived class it will be invoked instead of the base class
            BaseClass B = new DerivedClass();
            B.Print();

            DerivedClass D = new DerivedClass();
            D.Print();


        }
    }
}



