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
    // class A inherits from IA, class B inherits from IB
    // class AB should have the capability of A and B i.e what multiple inheritance tries to achieve
    // C#/.net will not allow inheritance from multiple classes AB : A, B
    /// </summary>
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

    class B : IB
    {
        public void BMethod()
        {
            Console.WriteLine("B");
        }
    }

    //class AB : A, B
    class AB : IA, IB
    {

        A a = new A();
        B b = new B();

        public void AMethod()
        {
            // as class A and B already have implementation the methods can be invoked
            a.AMethod();
        }

        public void BMethod()
        {
            b.BMethod();
        }

    }


    public class Program
    {
        // has the capability of class A and B
        public static void Main()
        {
            AB ab = new AB();
            ab.AMethod();
            ab.BMethod();

        }
    }

}



