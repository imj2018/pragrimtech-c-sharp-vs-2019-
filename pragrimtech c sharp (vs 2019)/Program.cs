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

    interface ICustomer1
    {
        void Print1();
    }

    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }


    //  if an interface implements other interfaces and your 
    //  class inherits from that interface, it must implement those
    //  members in the inheritance chain i.e Customer must implement Print1 and Print2
    //
    public class Customer : ICustomer2
    {
        public void Print1()
        {
            Console.WriteLine("Print1");
        }

        public void Print2()
        {
            Console.WriteLine("Print2");
        }
    }


    public class Program
    {

        public static void Main()
        {
            //Customer c1 = new Customer();
            //c1.Print1();
            //c1.Print2();

            //  cannot create an instance of an interface but a reference variable
            //  can point to a derived object
            //
            //  Print1 is only available to Customer1, Print2 is not available
            //  yet as it is not derived
            ICustomer1 cust1 = new Customer();
            cust1.Print1();

            ICustomer2 cust = new Customer();
            cust.Print1();
            cust.Print2();

        }

    }












   


}



