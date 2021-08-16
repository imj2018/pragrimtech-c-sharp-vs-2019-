using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;


namespace pragrimtech_c_sharp__vs_2019_
{
    interface IA
    {
        void AMethod();
    }

    class A : IA
    {
        public void AMethod()
        {
            Console.WriteLine("A");
        }
    }

    interface IB
    {
        void BMethod();
    }
    class B: IB
    {
        public void BMethod()
        {
            Console.WriteLine("B");
        }
    }

    //class AB : A, B
    class AB : IA, IB
    {
        // instead of re-implementing use the implementation 
        // from class A and B
        A a = new A();
        B b = new B();

        public void AMethod()
        {
            a.AMethod();
        }

        public void BMethod()
        {
            b.BMethod();
        }
    }

    public class Program
    {
        public static void Main()
        {
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();
        }
    }
}



