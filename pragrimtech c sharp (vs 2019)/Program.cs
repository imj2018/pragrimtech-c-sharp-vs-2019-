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

    interface ICustomer
    {

        //  cannot have fields
        //int ID;


        //  can only have declarations
        // 
        //  are public by default cannot use other access modifiers
        //
        //private void Print();
        void Print();


        //  cannot have impementation in Interfaces
        //  
        //Console.WriteLine("Hello");
    }

    interface I2
    {
        void I2Method();
    }

    //  multiple interface inheritance is allowed
    //
    public class Customer : ICustomer, I2
    {

        //  must provide implementation for Interface members
        //  
        //  signature method must match Interface method
        //public void Print(int Name)

        public void Print()
        {
            Console.WriteLine("Interface Print Method");
        }

        public void I2Method()
        {
            Console.WriteLine("I2 Method");
        }
    }

    public class Sample 
    {

    }


    //  multiple class inheritance is not allowed
    //
    //public class Program : Customer, Sample

    public class Program
    {

        public static void Main()
        {
            ICustomer c1 = new Customer();
            c1.Print();
            
        }

    }












   


}



