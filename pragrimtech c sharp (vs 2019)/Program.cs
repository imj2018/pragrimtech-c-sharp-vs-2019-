using System;
using System.Collections.Generic;
//using PATA = ProjectA.TeamA; // project alias
//using PATB = ProjectA.TeamB;
using ProjectA.TeamA;
using ProjectA.TeamB;
using System.IO;


/// <summary>
/// "Attributes allow you to add declarative information to your programs. This information
/// can be queried at runtime using reflection."
/// 
/// [Obsolete]
/// [WebMethod]
/// [Serializable]
/// 
/// </summary>
namespace pragrimtech_c_sharp__vs_2019_
{
    public class Program
    {

        public static void Main()
        {
            // cannot be used if 
            //Calculator.Add(10, 20);
            //Calculator.Add(10, 20, 30);

            Calculator.Add(new List<int> { 10, 20, 30, 40, 50, 60, 70 });

        }

    }

    public class Calculator
    {
        //[Obsolete]
        //[Obsolete("Use Add(List<int> Numbers) Method")]
        // if last parameter set to true if it is obsolete it will be seen as an error 
        [Obsolete("Use Add(List<int> Numbers) Method", true)]
        public static int Add(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }

        //public static int Add(int FirstNumber, int SecondNumber, int ThirdNumber)
        //{
        //    return FirstNumber + SecondNumber + ThirdNumber;
        //}


        // using a List to add any amount of numbers instead of multiple
        // overloaded methods
        public static int Add(List<int> Numbers)
        {
            int Sum = 0;
            foreach (var Number in Numbers)
            {
                Sum = Sum + Number;
            }

            return Sum;
        }
    }

}



