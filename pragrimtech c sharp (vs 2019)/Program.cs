using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;


namespace pragrimtech_c_sharp__vs_2019_
{

    public class Program
    {
        public static void Main()
        {
            int Sum;
            Add(2, 3, out Sum);
        }

        public static void Add(int FN, int SN) // the signature is Add(int FN, int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        // can also be overloaded based on type of parameter
        public static void Add(float FN, int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        // params keyword does not count towards overloading and will throw an error
        public static void Add(float FN, int SN, params int[] TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        //public static void Add(float FN, int SN,int[] TN)
        //{
        //    Console.WriteLine("Sum = {0}", FN + SN);
        //}

        // not possible to overload a function based on the type (written type) i.e return type int
        //public static int Add(float FN, int SN)
        //{
        //    Console.WriteLine("Sum = {0}", FN + SN);
        //    return FN + SN;
        //}

        // out will have a return value
        // to reiterate the paramter types are value, ref, output, params arrays
 
        public static void Add(int FN, int SN, int TN) // overloading
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN);
        }

        public static void Add(int FN, int SN, int TN, int fourth) 
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN + fourth);
        }


    }

}



