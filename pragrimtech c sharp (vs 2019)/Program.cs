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
    //  an abstract class cannot be sealed 
    //
    //public abstract sealed class Customer
    public abstract class Customer
    {
        //  when marked as abstract there can no longer 
        //  be implementation details 
        //  
        //public abstract void Print()
        //{

        //}

        public abstract void Print();

        //  abstract classes are not required to have abstract members
        //  
        public void PrintNonAbstract()
        {
            Console.WriteLine("Print");
        }


    }

    //  like in interfaces abstract members must be implemented
    //  
    //public class Program : Customer

    //  mark as abstract and it won't require implementation
    //
    //public abstract class Program : Customer
    public class Program : Customer
    {
        public static void Main()
        {
            //  an abstract class can only be used as a base class like
            //  an interface an instance cannot be created but an abstract
            //  class reference variable can point to a derived object
            //
            Customer c = new Program();
            c.Print();
            c.PrintNonAbstract();

        }

        public override void Print()
        {
            Console.WriteLine("Print Method");
        }
    }

    
}















