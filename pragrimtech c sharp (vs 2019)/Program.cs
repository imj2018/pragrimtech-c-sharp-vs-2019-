using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.Linq;

namespace pragrimtech_c_sharp__vs_2019_
{
    // struct is directly on the stack 
    // structs can't inherit from another class or struct but can use interfaces, interface inheritance
    // sealed means in cannot be inherited/derived from, structs are sealed
    //public sealed class Customer 
    public struct Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("The ID is {0} and the Name is {1}", ID, Name );
        }

        public static void PrintComparedObjectNames(string name1, string name2)
        {
            Console.WriteLine("object one name is {0} object two name is {1}", name1, name2);
        }

        // structs can't have destructors
        //~Customer()
        //{
                
        //}

        // structs must have parameters in the constructor
        // structs do not have the concept of object references
        //public Customer()
        //{

        //}


    }


    public class Program 
    {
        public static void Main()
        {
            // structs are value types
            // int is just an alis for System.Int32 i = 0;
            // a value type will be removed from memory when the block has finished executing i.e scope is lost
            // i.e i it will be destroyed when main has completed executing
            int i = 0;


            if (i == 10)
            {
                // j will be removed once the if block is done
                int j = 20;
                
                // reference variable on the stack, object itself is on the heap
                // the reference variable will be destroyed  but the object still exists on the heap
                // and will be destroyed by the garbage collector when it sees no pointer
                //Customer C1 = new Customer();
                //C1.ID = 101;
                //C1.Name = "Mark";
            }
            Console.WriteLine("Hello");


            // stacki will remain 10, stackj although it is assigned to stacki will make a copy
            // therefore stackj + 1 will be 11 and will not affect the value of stacki
            int stacki = 10;
            int stackj = stacki; 
            stackj = stackj + 1;

            Console.WriteLine("stacki = {0} and stackj = {1}", stacki, stackj );

            Customer C1 = new Customer()
            {
                ID = 101,
                Name = "Mark"
            };

            Customer C2 = C1;
            C2.Name = "Mary";
            Customer.PrintComparedObjectNames(C1.Name, C2.Name);
        }
    }

}



