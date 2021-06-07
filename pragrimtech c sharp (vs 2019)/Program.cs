using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.Linq;


//public delegate void SampleDelegate();
//public delegate int SampleDelegate();
public delegate void SampleDelegate(out int Number);



namespace pragrimtech_c_sharp__vs_2019_
{
    /// <summary>
    // multicast delegate points to more than one function 
    // there are 2 approached
    // + or +=, - or -=
    // added to a method invocation list, they will be called in the order registered
    // if the method has a return type or an out parameter, the last method in the invocation list will be called
    // can use delegates for the observer (pub/sub)  design pattern 
    /// </summary>
    class Pragim
    {
       public static void Main()
        {
         // point delegate to function then invoke delegate
         // i.e register the method SampleMethodOne to the delegate sampleDelegate
         //SampleDelegate sampleDelegate = new SampleDelegate(SampleMethodOne);
         //sampleDelegate();

            SampleDelegate del1, del2, del3, del4;
            del1 = new SampleDelegate(SampleMethodOne);
            del2 = new SampleDelegate(SampleMethodTwo);
            //del3 = new SampleDelegate(SampleMethodThree);

            // delegate 4 is now pointing to all 3 methods by chaining with the + sign
            // - remove a delegate
            // use + to make use of different instances
            //del4 = del1 + del2 + del3;
            //del4 = del1 + del2 + del3 - del2;
            //del4();

            // if you want to use the same instance and register multiple functions +=
            // allows the delegate not just the one passed in the constructor 
            // we are registering SampleMethodTwo with del5,
            //SampleDelegate del5 = new SampleDelegate(SampleMethodOne);
            //del5 += SampleMethodTwo;
            //del5 += SampleMethodThree;
            //del5 -= SampleMethodOne;

            // though  the delegate is pointing at two functions, it will return the value from the
            // last method in the invocation list i.e SampleMethodTwo
            //SampleDelegate del5 = new SampleDelegate(SampleMethodOne);
            //del5 += SampleMethodTwo;
            //int DelegateReturnValue = del5();

            //Console.WriteLine("DelegateReturnValue = {0} " + DelegateReturnValue);

            // with an output paramter, it will still return the last value in the invokation list
            SampleDelegate del5 = new SampleDelegate(SampleMethodOne);
            del5 += SampleMethodTwo;
            int DelegateReturnOutputParameter = -1;

            del5(out DelegateReturnOutputParameter);

            Console.WriteLine("DelegateReturnValue = {0} " + DelegateReturnOutputParameter);


        }

        //public static void SampleMethodOne()
        // return type
        //public static int SampleMethodOne()
        // out parameter
        public static void SampleMethodOne(out int Number)
        {
            Number = 1;
        }

        public static void SampleMethodTwo(out int Number)
        {
            Number = 2;
        }

        public static void SampleMethodThree()
        {
            Console.WriteLine("SampleMethodThree Invoked");
        }

    }

}







