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
            //int i = 10;
            //int j = 10;

            // System.Object all types in .NET directly or indirectly inherit
            //Console.WriteLine(i == j);
            //Console.WriteLine(i.Equals(j));


            Direction direction1 = Direction.East;
            Direction direction2 = Direction.West;

            //Console.WriteLine(direction1 == direction2);
            //Console.WriteLine(direction1.Equals(direction2));


            Customer C1 = new Customer();
            C1.FirstName = "Simon";
            C1.LastName = "Tan";

            //Customer C2 = C1;
            //C2.LastName = "poo";


            Customer C2 = new Customer();
            C2.FirstName = "Simon";
            C2.LastName = "Tan";

            // value equality is the same but reference equality (reference variable) is
            // different, it will return false as they are referencing different objects
            Console.WriteLine("reference equality = {0}", C1 == C2);
            Console.WriteLine("value equality (overriden Equals method) = {0}", C1.Equals(C2));


            // messing around
            //if (Calculate.AreEqual<int>(10, 10))
            if (Calculate<int>.AreEqual(10, 10))
            {
                //Console.WriteLine("Equal");
            }
            else
            {
                //Console.WriteLine("Not Equal");
            }
         }

    }

    public enum Direction
    {
        East = 1,
        West = 2,
        North = 3,
        South = 4
    }


    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.LastName + ", " + this.FirstName;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            // needs to check if a Customer or derived/inherited from Customer
            if (!(obj is Customer))
            {
                return false;
            }

            // check for this instance of FirstName or LastName
            return 
                this.FirstName == ((Customer)obj).FirstName &&
                this.LastName == ((Customer)obj).LastName;

        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
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



