using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.Linq;
using System.IO;


namespace pragrimtech_c_sharp__vs_2019_
{
    class Pragim
    {
        public static void Main()
        {
            Add(5, 6);

        }

        public static void Add(int FN, int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN);
        }

        //public static int Add(int FN, int SN, int TN)
        //{
        //    return FN + SN + TN;
        //}

        public static void Add(int FN, int SN, params int[] TN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        //public static void Add(int FN, int SN, int[] TN)
        //{
        //    Console.WriteLine("Sum = {0}", FN + SN);
        //}

        public static void Add(int FN, int SN, out int Sum)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
            Sum = FN + SN;
        }

        public static void Add(float FN, float SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        public static void Add(int FN, float SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        public static void Add(int FN, int SN, int TN, int FourthNumber)
        {
            Console.WriteLine("Sum = {0}", FN + SN + TN + FourthNumber);
        }

    }


}







