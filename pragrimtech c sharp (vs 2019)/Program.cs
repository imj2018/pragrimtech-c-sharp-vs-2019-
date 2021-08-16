using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;


namespace pragrimtech_c_sharp__vs_2019_
{

    public delegate void HelloFunctionDelegate(string message);
 
    public class Program
    {
        public static void Main()
        {
            // A delegate is a type safe function pointer

            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from Delegate");

        }

        //public static string Hello(string message)
        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }
}



