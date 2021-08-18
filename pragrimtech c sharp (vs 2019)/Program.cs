using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.IO;
using System.Reflection;

/// <summary>
/// 
/// 
/// </summary>
namespace pragrimtech_c_sharp__vs_2019_
{
    public class Program
    {
        public static void Main()
        {
            int Number = 10;
            Console.WriteLine(Number.ToString());

            Customer C1 = new Customer()
            {
                FirstName = "Simon",
                LastName = "Tan"
            };

            Console.WriteLine(C1.ToString());

            // alternatively the convert class
            Console.WriteLine(Convert.ToString(C1));



            // messing around
            //if (Calculate.AreEqual<int>(10, 10))
            if (Calculate<int>.AreEqual(10, 10))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }

    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.LastName + ", " + this.FirstName;
        }
    }



    //public class Calculate
    public class Calculate<T>
    {
        //public static bool AreEqual<T>(T value1, T value2 )

        public static bool AreEqual(T value1, T value2)
        {
            return value1.Equals(value2);

        }

    }


}



