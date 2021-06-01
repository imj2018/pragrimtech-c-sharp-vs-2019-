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
    // class A is super base class
    // both class B and C are overriding the virtual method from A
    // if class D could inherit from B and C and does not override the Print method which
    // should it invoke from B or C? i.e the Diamond problem
    /// </summary>
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A implementation");
        }

    }

    class B : A
    {
        public override void Print()
        {
            //base.Print();
            Console.WriteLine("B Implementation");
        }

    }

    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C Implementation");
        }
    }

    class D : B, C
    {

    }

    public class Program
    { 
        public static void Main()
        {
            B b = new B();
            b.Print();

            D d = new D();
            d.Print();
        }
        

    }

}



