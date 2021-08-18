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
            Customer C1 = null;

            // depends on architecture

            // ToString will throw a exception if null
            string str = C1.ToString();

            // Convert will convert null values to an empty strings " "
            //string str = Convert.ToString(C1);

            Console.WriteLine(str);
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






}



