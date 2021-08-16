using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;


namespace pragrimtech_c_sharp__vs_2019_
{
    // abstract class can inherit from another abstract class or interface
    public abstract class Customer : ICustomer
    {
        public void Print()
        {
            Console.WriteLine("Print");
        } 
    }

    // interface can only inherit form another interface
    public interface ICustomer
    {
        // can't have implementation or fields
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



