using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.IO;
using System.Reflection;
using System.Text;

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

            // StringBuilder should be used when there is heavy manipulation
            // of strings

            //string userString = "C#";

            //// userString will no longer point to the "C#" object it is immutable
            //// and can't be changed in memory instead another new string object
            //// will be created for with the value copied over and concatenated to
            //// make "C# Video" and so on 4 of the 5 objects will essentially be
            //// discarded as orphaned objects
            //userString += " Video ";
            //userString += " Tutorial ";
            //userString += " for";
            //userString += " Beginners";

            // instead use StringBuilder which is Mutable
            StringBuilder userString = new StringBuilder("C#");
            userString.Append(" Video");
            userString.Append(" Tutorial");
            userString.Append(" for");
            userString.Append(" Beginners");

            Console.WriteLine(userString.ToString());


            string userStringExample = string.Empty;
            for (int i = 0; i <= 10000; i++)
            {
                userStringExample += i.ToString() + " ";
            }
            Console.WriteLine(userStringExample);

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



