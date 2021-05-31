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
    // if two methods have the same method signature and both
    // are impemented, it is not certain which will be invoked
    /// </summary>
    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }
    public class Program : I1, I2
    {
        //public void interfaceMethod()
        // explicit to avoid ambiguity, no access modifier interface name then a .
        //void I1.InterfaceMethod()
        // if a default implementation is needed set the access modifier to public
        // with no name . declaration
        public void InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
        }

        public static void Main()
        {
            Program P = new Program();

            // type cast is needed to define, i.e type cast to type interface I1. the only way to invoke is using an
            // interface reference variable like so
            ((I1)P).InterfaceMethod(); 
            ((I2)P).InterfaceMethod();

            // alternative to type casting
            I1 i1 = new Program();
            I2 i2 = new Program();

            i1.InterfaceMethod();
            i2.InterfaceMethod();

            Program P2 = new Program();

            // can be seen in intellisense as it is set to default
            P2.InterfaceMethod();
            ((I2)P2).InterfaceMethod();





        }
    }

}



