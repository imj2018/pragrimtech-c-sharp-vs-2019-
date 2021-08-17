using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.IO;

 
namespace pragrimtech_c_sharp__vs_2019_
{

    public class Program
    {
        /// <summary>
        /// enums are value types 
        /// an enum is a strongly typed constant
        /// enum by default has underlying data type of integer starting at 0
        /// </summary>
        public static void Main()
        {
             //type cast to int array
            //int[] values = (int[])Enum.GetValues(typeof(Gender));
             //Enum class contains static methods to operate on enumerations
            short[] values = (short[])Enum.GetValues(typeof(Gender));

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            string[] names = ((string[])Enum.GetNames(typeof(Gender)));

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            // though the underlying type is int a type cast or converstion is required
            //Gender gender = (Gender)3;
            int number = (int)Gender.Unkown;

            Gender gender = (Gender)Season.Winter;
            Console.WriteLine(gender);

        }

    }

    //public enum Gender

    // : to set underlying type
    //public enum Gender
    public enum Gender : short
    {
        //Unkown,
        // will start at 1 instead of 0 or set to any value
        //Unkown = 1,
        //Male = 3,
        //Female = 23
        Unkown = 1,
        Male = 2,
        Female = 3
    }

    public enum Season
    {
        Winter = 1,
        Spring = 2,
        Summer = 3
    }

}



