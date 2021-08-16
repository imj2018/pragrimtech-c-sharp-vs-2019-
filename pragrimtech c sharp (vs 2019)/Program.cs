using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;


namespace pragrimtech_c_sharp__vs_2019_
{
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
        //void I1.InterfaceMethod()
        // default
        public void InterfaceMethod()
        {
            Console.WriteLine("I1 interface Method");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 interface Method");
        }

        public static void Main()
        {
            //Program P = new Program();
            // cannot acces through class reference variable
            // must use interface reference variable
            //((I1)P).InterfaceMethod();
            //((I2)P).InterfaceMethod();

            //I1 I1 = new Program();
            //I2 I2 = new Program();
            //I1.InterfaceMethod();
            //I2.InterfaceMethod();

            Program P = new Program();
            P.InterfaceMethod();
            ((I2)P).InterfaceMethod();
            


        }


    }
}



