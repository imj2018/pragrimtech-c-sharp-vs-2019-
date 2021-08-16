using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;


namespace pragrimtech_c_sharp__vs_2019_
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Implementation");
        }
    }
   
    class B : A
    {
        public override void Print()
        {
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

    // diamond problem
    class D : B, C
    {
    }

    public class Program
    {
        public static void Main()
        {
            D d = new D();
            d.Print();
        }
    }
}



