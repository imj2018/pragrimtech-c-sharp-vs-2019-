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
            AddNumbers(10, 20);

            //AddNumbers(10, 20, 30, 40, 50);

            //AddNumbers(10, 20, new object[] { 30, 40, 50 });

            AddNumbers(10, 20, null);

            AddNumbers(10, 20, new int[] { 30, 40, 50 }); 

        }

        public static void AddNumbers(int firstNumber, int secondNumber)
        {
            //  call the AddNumber method (below), a third parameter can
            //  be used as alternative to params i.e method overloading for
            //  optional parameters
            AddNumbers(firstNumber, secondNumber, null);
        }

        public static void AddNumbers(int firstNumber, int secondNumber, 
            int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfNumbers != null)
            {
                foreach (int number in restOfNumbers)
                {
                    result += number;
                }
            }

            Console.WriteLine("Sum = " + result);

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



