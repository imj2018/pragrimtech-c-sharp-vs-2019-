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
    // "A delegate is a type safe function pointer"
    // the syntax of a delegate is like a function
    // a delegate keyword should be used, think of the syntax as method with the delegate keyword and similiar
    // to a method signature
    // this delegate can now be used to point to a function with a similar signature i.e a return type void
    // and a string parameter
    /// </summary>
    public delegate void HelloFunctionDelegate(string message);
    public delegate int NumberCalculationDelegate();

    public class Program
    {
        public static void Main()
        {
            // like a class an instance of delegate can be created then in the constructor pass
            // the function the delegate should point to 
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);

            // to invoke the delegate, behind the scenes the Hello method will be called
            // then pass the something for the string parameter
            del("Hello from Delegate");

            NumberCalculationDelegate nc = new NumberCalculationDelegate(NumberCalculation);
            Console.WriteLine(nc());
        }

        // type safe, the delegate needs to match the signature it points to 
        //public static string void Hello(string message)
        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }

        public static int NumberCalculation()
        {
            return 1 + 1;
        }

    }



}



