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
            
            AddNumbers(10, 20, new int[] { 30, 40, 50 });
            Console.WriteLine("");

            AddNumbers(10, 20);
            Console.WriteLine("");

            //Test(1);

            //  use named parameters to pass a value for paramter c (int c = 20)
            //  i.e skip the second parameter which will use the default value and
            //  set = 2 
            Test(1, c: 2);

        }

        //  set a default parameter to make it optional
        //  i.e int[] restOfNumbers = null
        //
        //  as in previous example, optional parameters must be last
        public static void AddNumbers(int firstNumber, int secondNumber, 
            //int[] restOfNumbers = null)
            params int[] restOfNumbers)
        {
            int result = firstNumber + secondNumber;

            //  false if no third parameter passed, loop won't be executed
            if (restOfNumbers != null)
            {
                foreach (int number in restOfNumbers)
                {
                    result += number;
                }

                Console.WriteLine("Sum with default/optional paramter = " + result);
            }

            Console.WriteLine("Sum = " + result);

        }

        //  a is mandatory, b and c are optional as a default parameter is set
        public static void Test(int a, int b = 10, int c = 20)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);

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



