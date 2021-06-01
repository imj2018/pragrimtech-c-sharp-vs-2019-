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
    // abstract class can have implementation for some of its members
    // or not, interface must implement all it's memebers/methods
    // abstract class members are private by default, interface members are public by default
    // abstract can have fields, interfaces cannot have fields
    // interfaces can inherit from other interfaces but not from other abstract classes
    // abstract class can inherit from another abstract class or another interface
    // interface members/methods cannot have access modifiers 
    /// </summary>
    public abstract class Customer
    {
        // not marked as abstract but can still be implemented
        public void Print()
        {
            Console.WriteLine("Print");
        }
    }

    public interface ICustomer
    {
        //int ID; 
        void Print();
    }

    public class Program
    { 
        public static void Main()
        {

        }
        

    }

}



