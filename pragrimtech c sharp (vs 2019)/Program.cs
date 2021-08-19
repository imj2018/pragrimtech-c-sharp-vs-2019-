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

            AddNumbers(10, 20, 30, 40, 50);

            //  also create as an object array
            AddNumbers(10, 20, new object[] { 30, 40, 50 });

        }

        //  to add more than one parameter use a params array
        // 
        //  the third parameter becomes optional because of the params keyword
        // 
        //  params must be the last parameter
        public static void AddNumbers(int firstNumber, int secondNumber, 
            params object[] restOfNumbers)
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



