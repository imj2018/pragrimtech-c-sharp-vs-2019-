using System;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.IO;
using System.Reflection;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.CodeAnalysis;
using System.Collections.ObjectModel;
using System.Threading;
using System.Diagnostics;

/// <summary>
///
/// 
/// </summary>
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

    //  both classes have the same method/method name 
    //  there is ambiguity as to which method is implemented
    //  .NET assumes both have been implemented
    // 
    public class Program : I1, I2
    {

        //  explicitely implement, remove the access modifier
        //  then the interface name followed by .
        //  
        //void I1.InterfaceMethod()
        //{
        //    Console. WriteLine("I1 Interface Method");
        //}

        //  if implemented normally it will become the default implementation
        //
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
            P.InterfaceMethod();

            //  could type cast to be clear which is implemented
            //            
            ((I1)P).InterfaceMethod();
            ((I2)P).InterfaceMethod();

            //  .NET will not allow P.InterfaceMethod();
            //  because of ambiguity, the interface variable must be used 
            //
            //  alernatively to type casting
            //
            I2 p2 = new Program();
            p2.InterfaceMethod();


        }


    }












   


}



