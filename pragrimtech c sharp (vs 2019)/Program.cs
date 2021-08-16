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
            //SampleDelegate del = new SampleDelegate(SampleMethodOne);
            //del();

            //SampleDelegate del1, del2, del3, del4;

            //del1 = new SampleDelegate(SampleMethodOne);
            //del2 = new SampleDelegate(SampleMethodTwo);
            //del3 = new SampleDelegate(SampleMethodThree);

            //// del4 is pointing to multiple functions i.e a multicast delegate 
            //del4 = del1 + del2 + del3 - del2;
            //del4();

            // register these methods to this delegate, delegate invocation list
            //SampleDelegate del = new SampleDelegate(SampleMethodOne);
            //del += SampleMethodTwo;
            //del += SampleMethodThree;
            //del -= SampleMethodOne;

            //del();

            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;

            // the last method in the invocation list will be returned
            //int delegateReturnValue = del();
            int delegateReturnOutputParameterValue = 0;
            del(out delegateReturnOutputParameterValue);

            Console.WriteLine(delegateReturnOutputParameterValue);


        }

        //public static void SampleMethodOne()
        //{
        //    Console.WriteLine("SampleMethodOne Invoked");
        //}
        //public static void SampleMethodTwo()
        //{
        //    Console.WriteLine("SampleMethodTwo Invoked");
        //}
        //public static void SampleMethodThree()
        //{
        //    Console.WriteLine("SampleMethodThree Invoked");

        //public delegate void SampleDelegate();
        //public delegate int SampleDelegate();
        public delegate void SampleDelegate(out int Number);

        //public static int SampleMethodOne()
        //{
        //    return 1;
        //}

        public static void SampleMethodOne(out int Number)
        {
            Number = 1;
        }

        //public static int SampleMethodTwo()
        //{
        //    return 2;
        //}

        public static void SampleMethodTwo(out int Number)
        {
            Number = 2;
        }


    }
}



