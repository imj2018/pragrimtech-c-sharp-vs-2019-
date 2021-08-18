using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.IO;
using System.Reflection;

/// <summary>
/// 
/// 
/// </summary>
namespace pragrimtech_c_sharp__vs_2019_
{
    public class Program
    {
        public static void Main()
        {
            //bool Equal = Calculator.AreEqual(1, 2);
            //bool Equal = Calculator.AreEqual("A", "A");

            // at runtime boxing and unboxing is occuring as 10 is integer which is a value/struct 
            // therefore it is cast to a reference type which degrades performance
            //bool Equal = Calculator.AreEqual(10, 10);

            // can also pass parameters that make no sense
            //bool Equal = Calculator.AreEqual(10, "AB");

            // "I want this method to operate on the string type"
            //bool Equal = Calculator.AreEqual<string>("AB", "AB");

            // no converstion will occur i.e boxing and unboxing
            //bool Equal = Calculator.AreEqual<int>(10, 10);
            bool Equal = Calculator<int>.AreEqual(10, 10);


            if (Equal)
            {
                Console.WriteLine("Are Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

        }

    }

    //public class Calculator

    // alternatively make class generic
    public class Calculator<T>
    {
        //public static bool AreEqual(int Value1, int Value2)

        // int, string etc directly or indirectly inherit from object in .NET
        // not longer strongly typed
        //public static bool AreEqual(object Value1, object Value2)

        // generics, type independant
        //public static bool AreEqual<T>(T Value1, T Value2)
        public static bool AreEqual(T Value1, T Value2)
        {
            //return Value1 == Value2;
            return Value1.Equals(Value2);
        }

    }


}



